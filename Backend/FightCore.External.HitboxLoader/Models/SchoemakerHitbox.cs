using FightCore.Models;

namespace FightCore.External.HitboxLoader.Models
{
	public class ShoemakerHitbox
	{
		public int id;
		public int damage;
		public int angle;
		public int kbGrowth;
		public int weightDepKb;
		public int baseKb;
		public string element;

		public Hitbox ToHitbox()
		{
			return new Hitbox
			{
				Angle = angle,
				BaseKnockback = baseKb,
				Damage = damage,
				Effect = char.ToUpper(element[0]) + element.Substring(1),
				KnockbackGrowth = kbGrowth,
				SetKnockback = weightDepKb,
				Name = "id"+id
			};
		}
	}
}
