namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class StartLoopCommandDto : ScriptCommandDto
	{
		public ushort Iterations { get; set; }
		
		public override CommandType CommandType => CommandType.StartLoop;
	}
}
