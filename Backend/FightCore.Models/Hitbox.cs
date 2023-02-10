using FightCore.Models.Base;

namespace FightCore.Models
{
    public class Hitbox : BaseEntity
    {
        public string Name { get; set; }

        public long Damage { get; set; }

        public long Angle { get; set; }

        // Ikneeddata = kg.
        public long KnockbackGrowth { get; set; }

        // Ikneeddata = wbk
        public long SetKnockback { get; set; }

        // Ikneeddata = bk
        public long BaseKnockback { get; set; }

        public string Effect { get; set; }

        public int HitlagAttacker { get; set; }

        public int HitlagDefender { get; set; }

        public int HitlagAttackerCrouched { get; set; }

        public int HitlagDefenderCrouched { get; set; }

        public int Shieldstun { get; set; }

        public int? YoshiArmorBreakPercentage { get; set; }

        public Move Move { get; set; }

        public long MoveId { get; set; }
    }
}
