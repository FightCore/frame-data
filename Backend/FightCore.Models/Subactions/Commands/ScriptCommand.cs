using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FightCore.Models.Subactions.Commands
{
	public class ScriptCommand
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[JsonIgnore]
		public long Id { get; set; }

		public int Order { get; set; }

		public string DisplayName { get; set; }

		public string Name { get; set; }

		public uint Type { get; set; }

		public uint Length { get; set; }

		public string HexString { get; set; }
	}
}
