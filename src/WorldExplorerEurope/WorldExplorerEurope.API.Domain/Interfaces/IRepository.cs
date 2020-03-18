using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetById(Guid Id);
        IQueryable<T> GetAll();
        IQueryable<T> GetSearchResults(Expression<Func<T, bool>> predicate);
        Task<T> Add(T Entity);
        Task<T> Update(T Entity);
        Task<T> Delete(Guid id);
        Task<T> Delete(T Entity);

    }
}
