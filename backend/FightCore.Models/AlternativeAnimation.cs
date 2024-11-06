using FightCore.Models.Base;
using Newtonsoft.Json;

namespace FightCore.Models
{
	public class AlternativeAnimation : BaseEntity
	{
		public string Description { get; set; }

		public string GifUrl { get; set; }

		public string WebmUrl { get; set; }

		public string PngUrl { get; set; }

		[JsonIgnore]
		public Move Move { get; set; }

		[JsonIgnore]
		public long MoveId { get; set; }
	}
}
