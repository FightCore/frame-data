using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services.Base;

namespace FightCore.Services
{
    public interface IHitboxService : IBaseService<Hitbox>
    {
        Task<List<Hitbox>> GetHitboxesByMove(long moveId);
    }

    public class HitboxService : BaseService<Hitbox, IHitboxRepository>, IHitboxService
    {
        public HitboxService(IHitboxRepository repository) : base(repository)
        {
        }

        public Task<List<Hitbox>> GetHitboxesByMove(long moveId)
        {
            return Repository.GetHitboxesByMove(moveId);
        }
    }
}
