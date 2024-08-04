using FightCore.Models;

namespace FightCore.External.HitboxLoader.Models
{
	public class ShoemakerHit
	{
		public string Name { get; set; }

		public int Start { get; set; }

		public int End { get; set; }

		public List<ShoemakerHitbox> Hitboxes { get; set; }

		public Hit ToHit()
		{
			return new Hit
			{
				Start = Start,
				End = End,
				Hitboxes = Hitboxes.Select(hitbox => hitbox.ToHitbox()).ToList()
			};
		}
	}
}
