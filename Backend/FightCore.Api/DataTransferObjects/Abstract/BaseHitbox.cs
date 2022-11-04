using FightCore.Models;

namespace FightCore.Api.DataTransferObjects.Abstract
{
    public class BaseHitbox
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

        public int Shieldstun { get; set; }

        public long MoveId { get; set; }
    }
}
