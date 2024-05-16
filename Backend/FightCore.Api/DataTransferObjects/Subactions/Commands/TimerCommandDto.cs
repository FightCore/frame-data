namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class TimerCommandDto : ScriptCommandDto
	{
		public ushort Frames { get; set; }
		
		public override CommandType CommandType => CommandType.Timer;
	}
}
