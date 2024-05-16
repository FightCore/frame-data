using FightCore.Models.Subactions.Commands;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FightCore.Models.Subactions
{
	public class Subaction
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		public int Index { get; set; }

		public string Name { get; set; }

		public SubactionHeader Header { get; set; }

		public List<ScriptCommand> Commands { get; set; }

		public List<MoveSubaction> MoveSubactions { get; set; }

		public long CharacterId { get; set; }

		public Character Character { get; set; }
	}
}
