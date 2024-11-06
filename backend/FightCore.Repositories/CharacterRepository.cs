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

        public override Task<List<Character>> GetAll()
        {
            return BasicIncludes.ToListAsync();
        }

        public override Task<Character> GetById(long id)
        {
            return Queryable
                .Include(character => character.Moves)
                .Include(character => character.CharacterStatistics)
                .Include(character => character.CharacterInfo)
                .FirstOrDefaultAsync(character => character.Id == id);
        }

        public Task<List<Character>> ExportAll()
        {
            return Queryable
                .Include(character => character.CharacterInfo)
                .Include(character => character.CharacterStatistics)
                .Include(character => character.Moves)
                .ThenInclude(move => move.Hits)
                .ThenInclude(hit => hit.Hitboxes)
                .Include(character => character.Moves)
                .ThenInclude(move => move.Sources)
                .Include(character => character.Moves)
                .ThenInclude(move => move.AlternativeAnimations)
    //            .ThenInclude(move => move.MoveSubactions)
    //            .ThenInclude(moveSubaction => moveSubaction.Subaction)
    //            .ThenInclude(subaction => subaction.Commands)
				//.Include(character => character.Subactions)
    //            .ThenInclude(subaction => subaction.Commands)
                .AsSplitQuery()
				.ToListAsync();
        }

        private IQueryable<Character> BasicIncludes =>
            Queryable.Include(character => character.CharacterInfo)
                .Include(character => character.CharacterStatistics);
    }
}
