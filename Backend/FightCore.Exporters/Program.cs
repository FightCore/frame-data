// See https://aka.ms/new-console-template for more information

using FightCore.FrameData;
using FightCore.Repositories;
using FightCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FightCore.Exporters;
using FightCore.External.MeleeDatabase;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var dbContextOptions =
	new DbContextOptionsBuilder<FrameDataContext>().UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
var dbContext = new FrameDataContext(dbContextOptions.Options);

var repository = new CharacterRepository(dbContext);
var services = new CharacterService(repository);

var export = await services.ExportAll();
export = export.OrderBy(character => character.Id).ToList();

var folder = configuration["Exports:Folder"];

await Exporter.Export(export, folder, "characters");
await DatabaseCreator.Export(export, Path.Combine(folder, "test.db"));

foreach (var character in export)
{
	var moves = character.Moves.Select(move =>
	{
		move.Character = null;
		move.CharacterId = default;
		return move;
	});
	moves = moves.OrderBy(move => move.Id).ToList();

	await Exporter.Export(moves, Path.Combine(folder, character.NormalizedName), "moves");
}