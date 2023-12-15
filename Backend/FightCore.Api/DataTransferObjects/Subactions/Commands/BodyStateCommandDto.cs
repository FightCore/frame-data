namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class BodyStateCommandDto : ScriptCommandDto
	{
		public BodyTypeDto BodyType { get; set; }
		
		public override CommandType CommandType => CommandType.BodyState;
	}
}
