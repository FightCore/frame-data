namespace FightCore.Models.Subactions.Commands
{
	public class ThrowCommand : ScriptCommand
	{
		public ThrowType ThrowType { get; set; }

		public int Damage { get; set; }

		public int KnockbackGrowth { get; set; }

		public int WeightDependantKnockback { get; set; }

		public ThrowElementType ThrowElement { get; set; }

		public int Angle { get; set; }

		public int BaseKnockback { get; set; }
	}
}
