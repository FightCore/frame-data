namespace FightCore.External.MeleeDatabase.Models
{
	internal class ThrowKeyConverter
	{
		private static readonly IReadOnlyDictionary<string, string> _dictionary = new Dictionary<string, string>()
		{
			{ "bthrow", "back_throw" },
			{ "fthrow", "forward_throw" },
			{ "dthrow", "down_throw" },
			{ "uthrow", "up_throw" },
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
