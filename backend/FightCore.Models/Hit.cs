using FightCore.Models.Base;

namespace FightCore.Models
{
	public class Hit : BaseEntity
	{
		public List<Hitbox> Hitboxes { get; set; }

		public int Start { get; set; }

		public int End { get; set; }

		public long MoveId { get; set; }

		public string Name { get; set; }
	}
}
