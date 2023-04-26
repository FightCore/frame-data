using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCore.External.MeleeDatabase.Models
{
	public static class CharacterKeyConverter
	{
		private static readonly IReadOnlyDictionary<string, string> _dictionary =
			new Dictionary<string, string>()
			{
				{ "captainfalcon", "captain_falcon" },
				{ "roy", "roy" },
				{ "pichu", "pichu" },
				{ "ness", "ness" },
				{ "mrgame&watch", "mr._game_&_watch" },
				{ "mewtwo", "mewtwo" },
				{ "link", "link" },
				{ "bowser", "bowser" },
				{ "kirby", "kirby" },
				{ "ganondorf", "ganondorf" },
				{ "donkeykong", "donkey_kong" },
				{ "mario", "mario" },
				{ "drmario", "dr._mario" },
				{ "luigi", "luigi" },
				{ "yoshi", "yoshi" },
				{ "iceclimbers", "ice_climbers" },
				{ "pikachu", "pikachu" },
				{ "peach", "peach" },
				{ "sheik", "sheik" },
				{ "samus", "samus" },
				{ "jigglypuff", "jigglypuff" },
				{ "marth", "marth" },
				{ "fox", "fox" },
				{ "falco", "falco" },
				{ "younglink", "young_link" },
				{ "zelda", "zelda" },
				{ "fwireframe", null }
			}.ToImmutableDictionary();

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
