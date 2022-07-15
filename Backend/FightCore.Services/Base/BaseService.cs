using FightCore.Models.Base;
using FightCore.Repositories.Base;

namespace FightCore.Services.Base
{
    public interface IBaseService<TModel>
        where TModel : BaseEntity
    {
        Task<TModel?> GetById(long id);

        Task<List<TModel>> GetByIds(ICollection<long> ids);

        Task<List<TModel>> GetAll();
    }

    public class BaseService<TModel, TRepository> : IBaseService<TModel>
        where TModel : BaseEntity
        where TRepository : IBaseRepository<TModel>
    {
        protected TRepository Repository { get; }

        public BaseService(TRepository repository)
        {
            Repository = repository;
        }

        public Task<TModel?> GetById(long id)
        {
            return Repository.GetById(id);
        }

        public Task<List<TModel>> GetByIds(ICollection<long> ids)
        {
            return Repository.GetByIds(ids);
        }

        public Task<List<TModel>> GetAll()
        {
            return Repository.GetAll();
        }
    }
}
