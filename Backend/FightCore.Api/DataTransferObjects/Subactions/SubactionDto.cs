using FightCore.Api.DataTransferObjects.Subactions.Commands;

namespace FightCore.Api.DataTransferObjects.Subactions
{
	public class SubactionDto
	{
		public long Id { get; set; }

		public int Index { get; set; }

		public string Name { get; set; }

		public SubactionHeaderDto Header { get; set; }

		public List<ScriptCommandDto> Commands { get; set; }

	}
}
