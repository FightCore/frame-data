using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services.Base;

namespace FightCore.Services
{
    public interface IMoveService : IBaseService<Move>
    {
        Task<Move?> GetMoveByCharacter(long moveId, long characterId);

        Task<List<Move>> GetMovesByCharacter(long characterId);
    }

    public class MoveService : BaseService<Move, IMoveRepository>, IMoveService
    {
        public MoveService(IMoveRepository repository) : base(repository)
        {
        }

        public Task<Move?> GetMoveByCharacter(long moveId, long characterId)
        {
            return Repository.GetMoveByCharacter(moveId, characterId);
        }

        public Task<List<Move>> GetMovesByCharacter(long characterId)
        {
            return Repository.GetMovesByCharacter(characterId);
        }
    }
}
