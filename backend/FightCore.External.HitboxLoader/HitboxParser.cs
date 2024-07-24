//using FightCore.External.HitboxLoader;
//using FightCore.External.HitboxLoader.Models;
//using Newtonsoft.Json.Linq;

//namespace FightCore.External.HitboxLoader
//{
//	public static class HitboxParser
//	{
//		public static KneeHitbox Parse(JToken jsonToken)
//		{
//			return jsonToken.ToObject<KneeHitbox>();
//		}
//	}
//}


//var json = JObject.Parse(File.ReadAllText("C://tmp/hitboxDB.json"));
//foreach (var character in json)
//{
//	if (!characterMap.TryGetValue(character.Key, out var fightCoreCharacterName))
//	{
//		continue;
//	}

//	var characterJson = JObject.Parse(File.ReadAllText($"C://tmp/{fightCoreCharacterName}.json"));
//	Console.WriteLine(fightCoreCharacterName);
//	foreach (var move in character.Value.Children())
//	{
//		var moveProp = move as JProperty;
//		if (!moveMap.TryGetValue(moveProp.Name, out var fightCoreMoveName))
//		{
//			continue;
//		}

//		var characterMove = characterJson[fightCoreMoveName];
//		Console.WriteLine(characterMove);

//		Console.WriteLine(fightCoreMoveName);

//		foreach (var hitbox in moveProp.Value.Children())
//		{
//			var hitboxProp = hitbox as JProperty;

//			if (hitboxProp.Value.Children().Any(child => child.Type == JTokenType.Property && (child as JProperty).Value.Children().Any()))
//			{
//				foreach (var hitboxValue in hitboxProp.Value.Children())
//				{
//					var hitboxValueProp = hitboxValue as JProperty;
//					Console.WriteLine(hitboxProp.Name + " " + hitboxValueProp.Name);
//					var parsedHitbox = HitboxParser.Parse(hitboxValueProp.Value);
//					Console.WriteLine(parsedHitbox.dmg);
//				}
//			}
//			else
//			{
//				Console.WriteLine(hitboxProp.Name);
//				var parsedHitbox = HitboxParser.Parse(hitboxProp.Value);
//				Console.WriteLine(parsedHitbox.dmg);
//			}
//		}
//	}

//	return;
//}