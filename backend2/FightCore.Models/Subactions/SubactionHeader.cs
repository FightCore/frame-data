using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FightCore.Models.Subactions
{
	public class SubactionHeader
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		public uint StringOffset { get; set; }

		public uint ScriptOffset { get; set; }

		public uint Unknown1Offset { get; set; }

		public uint Unknown2Offset { get; set; }

		public uint Unknown3Flags { get; set; }

		public uint Unknown4Offset { get; set; }

		public Subaction Subaction { get; set; }

		public long SubactionId { get; set; }
	}

}
