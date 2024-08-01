using FightCore.External.HitboxLoader;
using FightCore.External.HitboxLoader.Models;
using FightCore.FrameData;
using FightCore.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace FightCore.External.HitboxLoader
{
	public class KneeHit
	{
		public string Name { get; set; }

		public List<KneeHitbox> Hitboxes { get; set; }

		public Hit ToHit(long moveId)
		{
			return new Hit
			{
				Name = Name,
				// We have no way to know these
				Start = 0,
				End = 0,
				Hitboxes = Hitboxes.Select(hitbox => hitbox.ToHitbox()).ToList(),
				MoveId = moveId
			};
		}
	}
	public class KneeHitbox
	{
		public int dmg;
		public int angle;
		public int kg;
		public int wbk;
		public int bk;
		public string name;
		public string effect;

		public Hitbox ToHitbox()
		{
			return new Hitbox
			{
				Damage = dmg,
				Angle = angle,
				KnockbackGrowth = kg,
				SetKnockback = wbk,
				BaseKnockback = bk,
				Effect = effect,
				Name = name
			};
		}
	}
	public static class HitboxParser
	{
		private static Dictionary<string, string> characterMap = new Dictionary<string, string>()
		{
			{ "Zd", "zelda" },
			{ "Sh", "sheik" },
			{ "Kb", "kirby" },
			{ "Po", "iceclimbers" },
			// Nana, currently not included
			{ "Na", null },
			{ "CF", "captainfalcon" },
			{ "YL", "younglink" },
			{ "DK", "donkeykong" },
			{ "DM", "drmario" },
			{ "Fc", "falco" },
			{ "Fx", "fox" },
			{ "Bw", "bowser" },
			{ "Lk", "link" },
			{ "Ma", "mario" },
			{ "Mw", "mewtwo"},
			{ "Lg", "luigi" },
			{ "Ms", "marth" },
			{ "Ns", "ness" },
			{ "Pc", "peach" },
			{ "Pi", "pichu" },
			{ "Pk", "pikachu" },
			{ "Jp", "jigglypuff" },
			{ "Sm", "samus" },
			{ "Ys", "yoshi" },
			{ "GW", "mrgame&watch" },
			{ "Gn", "ganondorf" },
			{ "Ry", "roy" }
		};

		private static Dictionary<string, string> moveMap = new Dictionary<string, string>()
		{
			{ "neutralSpecial", "neutralb" },
			{ "upSpecial", "upb"},
			{ "sideSpecial", "sideb" },
			{ "downSpecial", "downb" },
			{ "jab", "jab1" },
			{ "dash", "dattack" },
			{ "ftilt", "ftilt" },
			{ "utilt", "utilt" },
			{ "dtilt", "dtilt" },
			{ "fsmash", "fsmash" },
			{ "usmash", "usmash" },
			{ "dsmash", "dsmash" },
			{ "nair", "nair" },
			{ "fair", "fair" },
			{ "bair", "bair" },
			{ "uair", "uair" },
			{ "dair", "dair" },
			{ "floor", "fgetup" },
			{ "edge", "edge" },
			{ "pummel", "pummel" },
			{ "fthrow", "fthrow" },
			{ "bthrow", "bthrow" },
			{ "uthrow", "uthrow" },
			{ "dthrow", "dthrow" },
			// Kirby Moves (oh god)
			{ "ShiekSpecial", "shiekspecial" },
			{ "ICsSpecial", "iceclimbersspecial" },
			{ "YLinkSpecial", "younglinkspecial" },
			{ "DocSpecial", "drmariospecial" },
			{ "FalcoSpecial", "falcospecial" },
			{ "FoxSpecial", "foxspecial" },
			{ "FalconSpecial", "captainfalconspecial" },
			{ "GanonSpecial", "ganondorfspecial" },
			{ "DKSpecial", "donkeykongspecial" },
			{ "ZeldaSpecial", "zeldaspecial" },
			{ "PuffSpecial", "jigglypuffspecial" },
			{ "MarthSpecial", "marthspecial" },
			{ "RoySpecial", "royspecial"},
			{ "MewtwoSpecial", "mewtwospecial" },
			{ "YoshiSpecial", "yoshispecial" },
			{ "MrGandWSpecial", "mrgameandwatchspecial" },
			{ "BowserSpecial", "bowserspecial" },
			{ "LinkSpecial", "linkspecial" },
			{ "LuigiSpecial", "luigispecial" },
			{ "MarioSpecial", "mariospecial" },
			{ "NessSpecial", "nessspecial" },
			{ "PeachSpecial", "peachspecial" },
			{ "PichuSpecial", "pichuspecial" },
			{ "PikaSpecial", "pikachuspecial" },
			{ "SamusSpecial", "samusspecial" },
			// Cargo throws
			{ "cargo_bthrow", "cargo_bthrow"},
			{ "cargo_dthrow", "cargo_dthrow"},
			{ "cargo_fthrow", "cargo_fthrow"},
			{ "cargo_uthrow", "cargo_uthrow" },

		};

		public static KneeHitbox Parse(JToken jsonToken)
		{
			return jsonToken.ToObject<KneeHitbox>();
		}

		public static void ParseAll(FrameDataContext context)
		{
			var json = JObject.Parse(File.ReadAllText("C://tmp/hitboxDB.json"));
			foreach (var character in json)
			{
				if (!characterMap.TryGetValue(character.Key, out var fightCoreCharacterName) || fightCoreCharacterName == null)
				{
					continue;
				}

				Console.WriteLine(fightCoreCharacterName);
				var moves = new Dictionary<string, List<KneeHit>>();
				foreach (var move in character.Value.Children())
				{
					var moveProp = move as JProperty;
					if (!moveMap.TryGetValue(moveProp.Name, out var fightCoreMoveName))
					{
						continue;
					}

					var fightCoreMove = context.Moves.Include(move => move.Hits).FirstOrDefault(move => move.NormalizedName == fightCoreMoveName && move.Character.NormalizedName == fightCoreCharacterName);

					if (fightCoreMove == null)
					{
						Console.WriteLine($"Missing {fightCoreCharacterName} - {fightCoreMoveName}");
						continue;
					}

					if (fightCoreMove.Hits.Count > 0)
					{
						continue;
					}

					var hits = new List<KneeHit>();
					var unknownHit = new KneeHit
					{
						Name = "unknown",
						Hitboxes = []
					};
					foreach (var hitbox in moveProp.Value.Children())
					{
						var hitboxProp = hitbox as JProperty;

						if (hitboxProp.Value.Children().Any(child => child.Type == JTokenType.Property && (child as JProperty).Value.Children().Any()))
						{
							var kneeHit = new KneeHit
							{
								Name = hitboxProp.Name,
								Hitboxes = []
							};
							foreach (var hitboxValue in hitboxProp.Value.Children())
							{
								var hitboxValueProp = hitboxValue as JProperty;
								var parsedHitbox = Parse(hitboxValueProp.Value);
								parsedHitbox.name = hitboxValueProp.Name;
								kneeHit.Hitboxes.Add(parsedHitbox);
							}
							hits.Add(kneeHit);
						}
						else
						{
							var parsedHitbox = HitboxParser.Parse(hitboxProp.Value);
							parsedHitbox.name = hitboxProp.Name;
							unknownHit.Hitboxes.Add(parsedHitbox);
						}
					}

					if (unknownHit.Hitboxes.Count > 0) {
						hits.Add(unknownHit);
					}

					var fightCoreHits = hits.Select(hit => hit.ToHit(fightCoreMove.Id)).ToList();
					context.Hits.AddRange(fightCoreHits);
					context.SaveChanges();
				}
			}
		}
	}
}


