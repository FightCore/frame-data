using FightCore.External.HitboxLoader;
using FightCore.FrameData;
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

var characterMap = new Dictionary<string, string>()
{
	{ "Zd", "zelda" }
};

var moveMap = new Dictionary<string, string>()
{
	{ "jab", "jab1" },
	{ "neutralSpecial", "neutralb" },
	{ "ftilt", "ftilt" }
};


var json = JObject.Parse(File.ReadAllText("C://tmp/hitboxDBJSON.json"));
foreach (var character in json)
{
	if (!characterMap.TryGetValue(character.Key, out var fightCoreCharacterName))
	{
		continue;
	}

	Console.WriteLine(fightCoreCharacterName);
	foreach (var move in character.Value.Children())
	{	
		var moveProp = move as JProperty;
		if (!moveMap.TryGetValue(moveProp.Name, out var fightCoreMoveName))
		{
			continue;
		}

		Console.WriteLine(fightCoreMoveName);

		foreach (var hitbox in moveProp.Value.Children())
		{
			var hitboxProp = hitbox as JProperty;

			if (hitboxProp.Value.Children().Any(child => child.Type == JTokenType.Property && (child as JProperty).Value.Children().Any()))
			{
				foreach(var hitboxValue in hitboxProp.Value.Children())
				{
					var hitboxValueProp = hitboxValue as JProperty;
					Console.WriteLine(hitboxProp.Name + " " + hitboxValueProp.Name);
					HitboxParser.Parse(hitboxValueProp.Value);
				}
			}
			else
			{
				Console.WriteLine(hitboxProp.Name);
				HitboxParser.Parse(hitboxProp.Value);
			}
		}
	}

	return;
}