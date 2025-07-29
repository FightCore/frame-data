using FightCore.Enricher;
using FightCore.FrameData;
using FightCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var dbContextOptions =
	new DbContextOptionsBuilder<FrameDataContext>().UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
var dbContext = new FrameDataContext(dbContextOptions.Options);

//var sources = await dbContext.Sources.ToListAsync();

var moves = await dbContext.Moves.Include(move => move.Character).ToListAsync();
var imageUrlValidator = new ImageUrlValidator();
var alternativeAnimationFinder = new AlternativeAnimationFinder();

foreach (var move in moves.Where(move => move.Type == MoveType.Tech))
{
	Console.WriteLine($"{move.Character.NormalizedName} {move.NormalizedName}");
	var gifUrl = $"beta/{move.Character.NormalizedName}/{move.NormalizedName}.gif";
	if (string.IsNullOrEmpty(move.GifUrl) && await imageUrlValidator.Validate(gifUrl))
	{
		move.GifUrl = "https://i.fightcore.gg/" + gifUrl;
	}

	var webmUrl = $"beta/{move.Character.NormalizedName}/{move.NormalizedName}.webm";
	if (string.IsNullOrEmpty(move.WebmUrl) && await imageUrlValidator.Validate(webmUrl))
	{
		move.WebmUrl = "https://i.fightcore.gg/" + webmUrl;
	}

	var pngUrl = $"png/{move.Character.NormalizedName}/{move.NormalizedName}.png";
	if (string.IsNullOrEmpty(move.PngUrl) && await imageUrlValidator.Validate(pngUrl))
	{
		move.PngUrl = "https://i.fightcore.gg/" + pngUrl;
	}

	dbContext.Update(move);
	await dbContext.SaveChangesAsync();

	var alternativeAnimations = alternativeAnimationFinder.Get(move.Character.NormalizedName, move.NormalizedName);
	foreach (var animationName in alternativeAnimations)
	{
		var alternativeAnimation = new AlternativeAnimation
		{
			Description = animationName,
			Move = move,
		};
		var alternativeGifUrl = $"beta/{move.Character.NormalizedName}/{animationName}.gif";
		if (dbContext.AlternativeAnimations.Any(animation => animation.GifUrl == "https://i.fightcore.gg/" + alternativeGifUrl))
		{
			continue;
		}

		if (await imageUrlValidator.Validate(alternativeGifUrl))
		{
			alternativeAnimation.GifUrl = "https://i.fightcore.gg/" + alternativeGifUrl;
		}

		var alternativeWebmUrl = $"beta/{move.Character.NormalizedName}/{animationName}.webm";
		if (await imageUrlValidator.Validate(alternativeWebmUrl))
		{
			alternativeAnimation.WebmUrl = "https://i.fightcore.gg/" + alternativeWebmUrl;
		}

		var alternativePngUrl = $"png/{move.Character.NormalizedName}/{animationName}.png";
		if (await imageUrlValidator.Validate(alternativePngUrl))
		{
			alternativeAnimation.PngUrl = "https://i.fightcore.gg/" + alternativePngUrl;
		}

		dbContext.Add(alternativeAnimation);
		await dbContext.SaveChangesAsync();
	}

	// Sleeping for a longer amount of time to not overwhelm the HTTP server with requests.
	// This is probably a non-issue but just to be safe.
	Thread.Sleep(50);
}