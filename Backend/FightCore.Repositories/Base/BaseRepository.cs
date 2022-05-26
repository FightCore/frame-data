using FightCore.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace FightCore.Repositories.Base
{
    public interface IBaseRepository<TModel>
        where TModel : BaseEntity
    {
        Task<TModel> GetById(long id);

        Task<List<TModel>> GetByIds(ICollection<long> ids);

        Task<List<TModel>> GetAll();
    }

    public class BaseRepository<TModel> : IBaseRepository<TModel>
        where TModel : BaseEntity
    {
        private readonly DbSet<TModel> _dbSet;

        public BaseRepository(DbContext context)
        {
            _dbSet = context.Set<TModel>();
        }

        public virtual Task<TModel> GetById(long id)
        {
            return Queryable.FirstOrDefaultAsync(model => model.Id == id);
        }

        public virtual Task<List<TModel>> GetByIds(ICollection<long> ids)
        {
            return Queryable.Where(model => ids.Contains(model.Id)).ToListAsync();
        }

        public virtual Task<List<TModel>> GetAll()
        {
            return Queryable.ToListAsync();
        }

        protected IQueryable<TModel> Queryable => _dbSet.AsQueryable();
    }
}
