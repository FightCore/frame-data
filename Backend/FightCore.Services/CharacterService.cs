using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services.Base;

namespace FightCore.Services
{
    public interface ICharacterService : IBaseService<Character>
    {
    }

    public class CharacterService : BaseService<Character, ICharacterRepository>, ICharacterService
    {
        public CharacterService(ICharacterRepository repository) : base(repository)
        {
        }
    }
}
