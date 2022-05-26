using FightCore.Models;
using FightCore.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FightCore.Repositories
{
    public interface ICharacterRepository : IBaseRepository<Character>
    {
    }

    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(DbContext context) : base(context)
        {
        }
    }
}
