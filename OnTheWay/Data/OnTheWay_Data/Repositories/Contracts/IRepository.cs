using OnTheWay_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTheWay_Data.Repositories.Contracts
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Table { get; }
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entityCollection);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);




    }
}
