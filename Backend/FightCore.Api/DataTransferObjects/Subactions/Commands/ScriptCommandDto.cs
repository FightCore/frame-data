namespace FightCore.Api.DataTransferObjects.Subactions.Commands
{
	public class ScriptCommandDto
	{
		public long Id { get; set; }

		public string DisplayName { get; set; }

		public string Name { get; set; }

		public uint Type { get; set; }

		public uint Length { get; set; }

		public string HexString { get; set; }

		public int Order { get; set; }

		public virtual CommandType CommandType => CommandType.Script;
	}
}
