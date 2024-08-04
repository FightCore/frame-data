using FightCore.Models;

namespace FightCore.External.MeleeDatabase.Models
{
	public class Grab
	{
		public string Char { get; set; }

		public string Type { get; set; }

		public int Start { get; set; }

		public int Total { get; set; }

		public string Notes { get; set; }

		public Grab(Character character, Move move)
		{
			Char = CharacterKeyConverter.GetCharValueForNormalizedName(character.NormalizedName);
			Type = GrabKeyConverter.GetCharValueForNormalizedName(move.NormalizedName);
			Start = move.Start.Value;
			Total = move.TotalFrames;
			Notes = move.Notes;
		}
	}
}
