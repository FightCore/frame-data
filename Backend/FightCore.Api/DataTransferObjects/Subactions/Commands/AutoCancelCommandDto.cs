namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class AutoCancelCommandDto : ScriptCommandDto
	{
		public bool AutoCancelEnabled { get; set; }
		
		public override CommandType CommandType => CommandType.AutoCancel;
	}
}
