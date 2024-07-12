using FightCore.Models;
using FightCore.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FightCore.Repositories
{
    public interface IHitboxRepository : IBaseRepository<Hitbox>
    {
        Task<List<Hitbox>> GetHitboxesByMove(long moveId);
    }
    public class HitboxRepository : BaseRepository<Hitbox>, IHitboxRepository
    {
        public HitboxRepository(DbContext context) : base(context)
        {
        }

        public Task<List<Hitbox>> GetHitboxesByMove(long moveId)
        {
            return Queryable.Where(hitbox => hitbox.MoveId == moveId).ToListAsync();
        }
    }
}
