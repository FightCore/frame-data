namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class ThrowCommandDto : ScriptCommandDto
	{
		public ThrowTypeDto ThrowType { get; set; }

		public int Damage { get; set; }

		public int KnockbackGrowth { get; set; }

		public int WeightDependantKnockback { get; set; }

		public ThrowElementTypeDto ThrowElement { get; set; }

		public int Angle { get; set; }

		public int BaseKnockback { get; set; }
		
		public override CommandType CommandType => CommandType.Throw;
	}
}
