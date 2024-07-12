namespace FightCore.External.MeleeDatabase.Models
{
	internal class AttackKeyConverter
	{
		private static readonly IReadOnlyDictionary<string, string> _dictionary = new Dictionary<string, string>()
		{
			{ "adownb", "adown_b" },
			{ "aneutralb", "aneutral_b" },
			{ "asideb", "aside_b" },
			{ "aupb", "aup_b" },
			{ "downb", "down_b" },
			{ "neutralb", "neutral_b" },
			{ "sideb", "side_b" },
			{ "upb", "up_b" },
			{ "bair", "bair"},
			{ "dair", "dair"},
			{ "dattack", "dattack"},
			{ "dsmash", "dsmash"},
			{ "dtilt", "dtilt"},
			{ "fair", "fair"},
			{ "fsmash", "fsmash"},
			{ "ftilt", "ftilt"},
			{ "jab1", "jab1" },
			{ "jab2", "jab2" },
			{ "jab3", "jab3" },
			{ "nair", "nair"},
			{ "rjab", "rjab"},
			{ "uair", "uair"},
			{ "usmash", "usmash"},
			{ "utilt", "utilt"},
		};

		public static IEnumerable<string> Keys()
		{
			return _dictionary.Keys;
		}

		public static string GetCharValueForNormalizedName(string normalizedName)
		{
			return _dictionary[normalizedName];
		}

		public static string GetNormalizedNameForCharValue(string charValue)
		{
			var pair = _dictionary.FirstOrDefault(x => x.Value == charValue);
			return pair.Key;
		}
	}
}
