namespace FightCore.External.MeleeDatabase.Models
{
	public static class DodgeKeyConverter
	{
		private static readonly IReadOnlyDictionary<string, string> _dictionary = new Dictionary<string, string>()
		{
			{ "rollbackwards", "back_roll" },
			{ "rollforward", "forward_roll" },
			{ "spotdodge", "spot_dodge" },
			{ "airdodge", "air_dodge" },
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
