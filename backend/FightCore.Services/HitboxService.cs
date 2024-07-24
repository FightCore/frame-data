using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services.Base;

namespace FightCore.Services
{
    public interface IHitboxService : IBaseService<Hitbox>
    {
    }

    public class HitboxService : BaseService<Hitbox, IHitboxRepository>, IHitboxService
    {
        public HitboxService(IHitboxRepository repository) : base(repository)
        {
        }
    }
}
