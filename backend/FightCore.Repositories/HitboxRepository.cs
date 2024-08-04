using FightCore.Models;
using FightCore.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FightCore.Repositories
{
    public interface IHitboxRepository : IBaseRepository<Hitbox>
    {
    }
    public class HitboxRepository : BaseRepository<Hitbox>, IHitboxRepository
    {
        public HitboxRepository(DbContext context) : base(context)
        {
        }
    }
}
