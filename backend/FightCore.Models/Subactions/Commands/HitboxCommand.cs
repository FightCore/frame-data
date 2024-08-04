namespace FightCore.Models.Subactions.Commands
{
	public class HitboxCommand : ScriptCommand
	{
		public int HitboxId { get; set; }

		public int UnknownR { get; set; }

		public int BoneId { get; set; }

		public int Unknown0 { get; set; }

		public int UnknownQ { get; set; }

		public int UnknownV { get; set; }

		public int Size { get; set; }

		public int ZOffset { get; set; }

		public int YOffset { get; set; }

		public int XOffset { get; set; }

		public HurtboxInteractionFlags HurtboxInteraction { get; set; }

		public int BaseKnockback { get; set; }

		public int ShieldDamage { get; set; }

		public int SFX { get; set; }

		public bool HitsGround { get; set; }

		public bool HitsAir { get; set; }

		public int KnockbackGrowth { get; set; }

		public int Damage { get; set; }

		public int WeightDependantKnockback { get; set; }

		public ElementType Element { get; set; }

		public int Angle { get; set; }
	}
}
