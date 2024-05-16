namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class PartialBodystateCommandDto : ScriptCommandDto
	{
		public ushort Bone { get; set; }
		
		public override CommandType CommandType => CommandType.PartialBodyState;
	}
}
