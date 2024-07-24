using FightCore.External.HitboxLoader;
using FightCore.External.HitboxLoader.Models;
using FightCore.FrameData;
using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var dbContextOptions =
	new DbContextOptionsBuilder<FrameDataContext>().UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
var dbContext = new FrameDataContext(dbContextOptions.Options);

var repository = new CharacterRepository(dbContext);
var services = new CharacterService(repository);

var export = await services.ExportAll();

var moveMap = new Dictionary<string, string>()
{
	{ "utilt", "utilt" },
	{ "ftilt", "ftilt_m" },
	{ "dtilt", "dtilt" },
	{ "jab1", "jab1" },
	{ "jab2", "jab2" },
	{ "dattack", "dashattack"},
	{ "fsmash", "fsmash_m"},
	{ "usmash", "usmash"},
	{ "dsmash", "dsmash"},
	{ "nair", "nair" },
	{ "fair", "fair" },
	{ "dair", "dair" },
	{ "uair", "uair" },
	{ "grab", "grab" },
	{ "dashgrab", "dashgrab" },
	{ "pummel", "pummel" },
};

var characters = Directory.GetFiles("C://tmp/hitboxes/").Select(file => Path.GetFileNameWithoutExtension(file));

foreach (var character in characters)
{
	Console.WriteLine(character);

	var characterJson = JObject.Parse(File.ReadAllText($"C://tmp/hitboxes/{character}.json"));
	foreach (var (fightcoreName, dataName) in moveMap)
	{
		Console.WriteLine(fightcoreName);

		var move = characterJson[dataName];
		if (move == null || move.Type == JTokenType.Null)
		{
			continue;
		}

		var hits = move["hitFrames"].ToObject<List<ShoemakerHit>>();
		var fightCoreMove = dbContext.Moves.Include(move => move.Hits).FirstOrDefault(move => move.NormalizedName == fightcoreName && move.Character.NormalizedName == character);
		if (fightCoreMove == null || fightCoreMove.Hits.Any())
		{
			continue;
		}

		var mappedHits = hits.Select(hit => hit.ToHit()).ToList();
		foreach (var hit in mappedHits)
		{
			hit.MoveId = fightCoreMove.Id;
		}
		dbContext.AddRange(mappedHits);
		dbContext.SaveChanges();
	}
}