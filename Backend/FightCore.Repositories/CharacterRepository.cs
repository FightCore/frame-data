using FightCore.Models;
using FightCore.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FightCore.Repositories
{
    public interface ICharacterRepository : IBaseRepository<Character>
    {
        Task<List<Character>> ExportAll();
    }

    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(DbContext context) : base(context)
        {
        }

        public Task<List<Character>> ExportAll()
        {
            return Queryable
                .Include(character => character.CharacterInfo)
                .Include(character => character.CharacterStatistics)
                .Include(character => character.Moves)
                .ThenInclude(move => move.Hitboxes)
                .ToListAsync();
        }
    }
}
