namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class PointerCommandDto : ScriptCommandDto
	{
		public uint Pointer { get; set; }
		
		public override CommandType CommandType => CommandType.Pointer;
	}
}
