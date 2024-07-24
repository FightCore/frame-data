using FightCore.External.HitboxLoader;
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

var characters = new List<string>()
{
	"zelda"
};

var moveMap = new Dictionary<string, string>()
{
	//{ "jab", "jab1" },
	//{ "neutralSpecial", "neutralb" },
	{ "utilt", "utilt" },
	{ "dattack", "dashattack"},
	{ "fsmash", "fsmash_m"},
	{ "usmash", "usmash"},
	{ "dsmash", "dsmash"}
};

foreach (var character in characters)
{
	var characterJson = JObject.Parse(File.ReadAllText($"C://tmp/{character}.json"));
	foreach (var (fightcoreName, dataName) in moveMap)
	{
		var move = characterJson[dataName];
		if (move == null)
		{
			continue;
		}

		var hits = move["hitFrames"].ToObject<List<Hit>>();
		var fightCoreMove = dbContext.Moves.FirstOrDefault(move => move.NormalizedName == fightcoreName && move.Character.NormalizedName == character);
		foreach (var hit in hits)
		{
			hit.MoveId = fightCoreMove.Id;
		}
		dbContext.AddRange(hits);
		dbContext.SaveChanges();
	}
}