using FightCore.Models;

namespace FightCore.External.MeleeDatabase.Models
{
	public class Throw
	{
		public string Char { get; set; }

		public string Type { get; set; }

		public int Start { get; set; }

		public int End { get; set; }

		public int Total { get; set; }

		public long? Percent { get; set; }

		public string Notes { get; set; }

		public Throw(Character character, Move move)
		{
			Char = CharacterKeyConverter.GetCharValueForNormalizedName(character.NormalizedName);
			Type = ThrowKeyConverter.GetCharValueForNormalizedName(move.NormalizedName);
			Start = move.Start.Value;
			End = move.End.Value;
			Total = move.TotalFrames;
			Percent = move.Hitboxes.FirstOrDefault()?.Damage;
			Notes = move.Notes;
		}
	}
}
