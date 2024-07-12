using FightCore.Models;

namespace FightCore.External.MeleeDatabase.Models
{
	internal class Dodge
	{
		public string Char { get; set; }

		public string Type { get; set; }

		public int? Start { get; set; }

		public int? Inv_End { get; set; }

		public int Total { get; set; }

		public string Notes { get; set; }

		public Dodge(Character character, Move move)
		{
			Char = CharacterKeyConverter.GetCharValueForNormalizedName(character.NormalizedName);
			Type = DodgeKeyConverter.GetCharValueForNormalizedName(move.NormalizedName);
			Start = move.Start;
			Total = move.TotalFrames;
			Inv_End = move.End;
			Notes = move.Notes;
		}
	}
}
