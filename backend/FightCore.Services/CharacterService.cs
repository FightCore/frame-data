using FightCore.Models;
using FightCore.Repositories;
using FightCore.Services.Base;
using Microsoft.Extensions.Caching.Distributed;

namespace FightCore.Services
{
    public interface ICharacterService : IBaseService<Character>
    {
        Task<List<Character>> ExportAll();
    }

    public class CharacterService : BaseService<Character, ICharacterRepository>, ICharacterService
    {
        public CharacterService(ICharacterRepository repository) : base(repository)
        {
        }

        public Task<List<Character>> ExportAll()
        {
            return Repository.ExportAll();
        }
    }
}
