namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class UnsolvedCommandDto : ScriptCommandDto
	{
		public override CommandType CommandType => CommandType.Unsolved;
	}
}
