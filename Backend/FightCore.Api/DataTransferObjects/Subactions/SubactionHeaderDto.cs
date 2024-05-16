namespace FightCore.Api.DataTransferObjects.Subactions
{
	public class SubactionHeaderDto
	{
		public long Id { get; set; }

		public uint StringOffset { get; set; }

		public uint ScriptOffset { get; set; }

		public uint Unknown1Offset { get; set; }

		public uint Unknown2Offset { get; set; }

		public uint Unknown3Flags { get; set; }

		public uint Unknown4Offset { get; set; }
	}

}
