using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Commons;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IGenericRepositories<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);

        Task AddRangeAsync(List<TEntity> entities);
        void Update(TEntity entity);

        void UpdateRange(List<TEntity> entities);
        void SoftRemove(TEntity entity);

        void SoftRemoveRange(List<TEntity> entities);
        
        Task<Pagination<TEntity>> ToPagination(int pageIndex = 0, int pageSize = 10);
    }
}
