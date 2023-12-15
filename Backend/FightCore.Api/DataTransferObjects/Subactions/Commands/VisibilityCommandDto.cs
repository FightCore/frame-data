namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class VisibilityCommandDto : ScriptCommandDto
	{
		public VisibilityConstantDto Visibility { get; set; }
		
		public override CommandType CommandType => CommandType.Visibility;
	}
}
