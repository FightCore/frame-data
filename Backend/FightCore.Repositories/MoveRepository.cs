using FightCore.Models;
using FightCore.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FightCore.Repositories
{
    public interface IMoveRepository : IBaseRepository<Move>
    {
        Task<Move?> GetMoveByCharacter(long moveId, long characterId);

        Task<List<Move>> GetMovesByCharacter(long characterId);
    }

    public class MoveRepository : BaseRepository<Move>, IMoveRepository
    {
        public MoveRepository(DbContext context) : base(context)
        {
        }

        public Task<Move?> GetMoveByCharacter(long moveId, long characterId)
        {
            return Queryable.FirstOrDefaultAsync(move => move.Id == moveId && move.CharacterId == characterId);
        }

        public Task<List<Move>> GetMovesByCharacter(long characterId)
        {
            return Queryable.Where(move => move.CharacterId == characterId).ToListAsync();
        }
    }
}
