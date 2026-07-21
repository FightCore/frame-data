using System.Text.Json;
using FightCore.FrameData;
using Fightcore.MeleeSearchExporter.Dto;
using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var dbContextOptions =
    new DbContextOptionsBuilder<FrameDataContext>().UseNpgsql(configuration.GetConnectionString("DefaultConnection")).UseSnakeCaseNamingConvention();
var dbContext = new FrameDataContext(dbContextOptions.Options);

var repository = new CharacterRepository(dbContext);
var services = new CharacterService(repository);

var export = await services.ExportAll();
export = export.OrderBy(character => character.Id).ToList();

var folder = configuration["Exports:Folder"];

foreach (var character in export)
{
    foreach (var move in character.Moves)
    {
        if (move.Sources != null)
        {
            foreach (var source in move.Sources)
            {
                source.Moves = null;
            }
        }
    }

}

var allMoves = export.SelectMany(character => { return character.Moves.Select(move => (character, move)); }).ToList();

var convertedDtos = allMoves.Select((moveAndCharacter) =>
{
    var move = moveAndCharacter.move;
    var character = moveAndCharacter.character;
    var hitboxes = move.Hits?.SelectMany(hit => hit.Hitboxes).Where(hitbox => hitbox != null).ToList() ?? [];
    return new DataEntryDto
    {
        Title = $"{move.Name} - {character.Name}",
        Tags =
        [
            character.NormalizedName,
            move.Name,
            move.NormalizedName,
            $"{move.NormalizedName} {character.NormalizedName}",
            $"{move.Name} {character.NormalizedName}",
        ],
        Image = move.GifUrl,
        Data = new DataDto
        {
            CharacterId = character.FightCoreId,
            MoveId = move.Id,
            TotalFrames = move.TotalFrames,
            Start = move.Start,
            End = move.End,
            IASA = move.IASA,
            AutoCancelBefore = move.AutoCancelBefore,
            AutoCancelAfter = move.AutoCancelAfter,
            LandLag = move.LandLag,
            LCancelledLandLag = move.LCanceledLandLag,
            NormalizedMoveName = move.NormalizedName,
            NormalizedCharacterName = character.NormalizedName,
            Damage = hitboxes.Select(hitbox => hitbox.Damage).Distinct().ToArray(),
            BaseKnockback = hitboxes.Select(hitbox => hitbox.BaseKnockback).Distinct().ToArray(),
            KnockbackGrowth = hitboxes.Select(hitbox => hitbox.KnockbackGrowth).Distinct().ToArray(),
            SetKnockback = hitboxes.Select(hitbox => hitbox.SetKnockback).Distinct().ToArray(),
            Angle = hitboxes.Select(hitbox => hitbox.Angle).Distinct().ToArray(),
            Notes = move.Notes,
            Character = character.Name,
            Move = move.Name,
        }
    };
});

Directory.CreateDirectory(folder);
await File.WriteAllTextAsync(Path.Combine(folder, "data-entries.json"),JsonSerializer.Serialize(convertedDtos));
