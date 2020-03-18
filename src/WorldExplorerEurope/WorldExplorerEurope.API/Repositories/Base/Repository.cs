using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly WorldExplorerContext _worldExplorerContext;
        public Repository(WorldExplorerContext worldExplorerContext)
        {
            _worldExplorerContext = worldExplorerContext;
        }

        /* <summary>
         Gets all instances of the current Entity.
         </summary> */
        public virtual IQueryable<T> GetAll()
        {
            return _worldExplorerContext.Set<T>().AsNoTracking();
        }

        /* <summary>
         Finds the current Entity via it's Id.
         </summary> */
        public virtual async Task<T> GetById(Guid id)
        {
            return await _worldExplorerContext.Set<T>().FindAsync(id);
        }

        /* <summary>
         Checks if entity already exists and add's a new Entity if it's not the case.
         </summary> */
        public async Task<T>Add(T entity)
        {
            var dbCheck = _worldExplorerContext.Set<T>().ToList();
            foreach(var dbObject in dbCheck)
            {
                if (dbObject == entity)
                    return null;
            }

            await _worldExplorerContext.SaveChangesAsync();
            return entity;
        }
        /* <summary>
         Updates the targeted entity. When it fails, it returns null.
         </summary> */
        public async Task<T> Update(T entity)
        {
            _worldExplorerContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _worldExplorerContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        /* <summary>
         Get's all of the requested search results. If it finds none it returns null.
         </summary> */
        public virtual IQueryable<T> GetSearchResults(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _worldExplorerContext.Set<T>().Where(predicate).AsNoTracking();
            }
            catch
            {
                return null;
            }
        }

        /* <summary>
         Deletes the requested entity. If it fails, it returns null
         </summary> */
        public async Task<T>Delete(T entity)
        {
            _worldExplorerContext.Set<T>().Remove(entity);
            try
            {
                await _worldExplorerContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        /* <summary>
        Finds the current Entity via it's Id. If it's null, it returns null.
        If not, it will go the asyncronous Task above with the entity.
         </summary> */
        public async Task<T>Delete(Guid id)
        {
            var entity = await _worldExplorerContext.Set<T>().FindAsync(id);
            if (entity != null) return await Delete(entity);
            return null;
        }


    }
}
