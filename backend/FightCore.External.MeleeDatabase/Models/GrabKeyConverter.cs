namespace FightCore.External.MeleeDatabase.Models
{
	internal class GrabKeyConverter
	{
		private static readonly IReadOnlyDictionary<string, string> _dictionary = new Dictionary<string, string>()
		{
			{ "grab", "standing_grab" },
			{ "dashgrab", "dash_grab" },
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
