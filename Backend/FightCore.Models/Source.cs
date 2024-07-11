using FightCore.Models.Base;

namespace FightCore.Models
{
	public class Source : BaseEntity
	{

		public string Name { get; set; }

		public string Url { get; set; }

		public List<Move> Moves { get; set; }
	}
}
