using FightCore.Models;

namespace FightCore.External.MeleeDatabase.Models
{
	public class Misc
	{
		public string Char { get; set; }

		public int Weight { get; set; }

		public double Gravity { get; set; }

		public double Walk_Speed { get; set; }

		public double Run_Speed { get; set; }

		public int Wd_Length { get; set; }

		public int Wd_Frames { get; set; }

		public int Jump_Squat { get; set; }

		public bool Wall_Jump { get; set; }

		public string Notes { get; set; }

		public Misc(Character character)
		{
			Char = CharacterKeyConverter.GetCharValueForNormalizedName(character.NormalizedName);
			Weight = character.CharacterStatistics.Weight;
			Gravity = character.CharacterStatistics.Gravity;
			Walk_Speed = character.CharacterStatistics.WalkSpeed;
			Run_Speed = character.CharacterStatistics.RunSpeed;
			Wd_Length = character.CharacterStatistics.WaveDashLengthRank;
			Wd_Frames = character.CharacterStatistics.PLAIntangibilityFrames;
			Jump_Squat = character.CharacterStatistics.JumpSquat;
			Wall_Jump = character.CharacterStatistics.CanWallJump;
			Notes = character.CharacterStatistics.Notes;
		}
	}
}
