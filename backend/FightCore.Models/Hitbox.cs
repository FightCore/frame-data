using System.Text.Json.Serialization;
using FightCore.Models.Base;
using Newtonsoft.Json;

namespace FightCore.Models
{
    public class Hitbox : BaseEntity
    {
        public string Name { get; set; }

        public long Damage { get; set; }

        public long Angle { get; set; }

        public long KnockbackGrowth { get; set; }

		public long SetKnockback { get; set; }

		public long BaseKnockback { get; set; }

		public string Effect { get; set; }

        public int HitlagAttacker { get; set; }

        public int HitlagDefender { get; set; }

        public int HitlagAttackerCrouched { get; set; }

        public int HitlagDefenderCrouched { get; set; }

        public int Shieldstun { get; set; }

        public int? YoshiArmorBreakPercentage { get; set; }

        public bool IsWeightIndependent { get; set; }
    }
}
