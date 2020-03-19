using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Repositories.Base
{
    public class MappingRepository<T, Dto> : Repository<T>, IMappingRepository<Dto> where T : EntityBase where Dto : DtoBaseId
    {
        protected readonly IMapper _mapper;

        public MappingRepository(WorldExplorerContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        /* <summary>
 Gets all instances of the current Entity.
 </summary> */
        public IQueryable<Dto> GetAll()
        {
            return _worldExplorerContext.Set<T>().ProjectTo<Dto>(_mapper.ConfigurationProvider) ;
        }

        public new async Task<IEnumerable<Dto>> ListAll()
        {
            return await _worldExplorerContext.Set<T>().ProjectTo<Dto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        /* <summary>
         Finds the current Entity via it's Id.
         </summary> */
        public new async Task<Dto> GetById(Guid id)
        {
            return await _worldExplorerContext.Set<T>().ProjectTo<Dto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync(m => m.Id == id);
        }

        /* <summary>
         Checks if entity already exists and add's a new Entity if it's not the case.
         </summary> */
        public virtual async Task<Dto> Add(Dto dto)
        {
            var entity = _mapper.Map<T>(dto);
            _worldExplorerContext.Set<T>().Add(entity);
            try
            {
                await _worldExplorerContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return dto;
        }
        /* <summary>
         Updates the targeted entity. When it fails, it returns null.
         </summary> */
        public async Task<Dto> Update(Dto dto)
        {
            var entity = _mapper.Map<T>(dto);
            _worldExplorerContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _worldExplorerContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return dto;
        }

        /* <summary>
         Get's all of the requested search results. If it finds none it returns null.
         </summary> */
        public IQueryable<Dto> GetSearchResults(Expression<Func<Dto, bool>> predicate)
        {
            try
            {
                return  _worldExplorerContext.Set<T>().AsNoTracking().ProjectTo<Dto>(_mapper.ConfigurationProvider).Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        /* <summary>
         Deletes the requested entity. If it fails, it returns null
         </summary> */
        public virtual async Task<Dto> Delete(Dto dto)
        {
            _worldExplorerContext.Set<T>().Remove(_mapper.Map<T>(dto));
            try
            {
                await _worldExplorerContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return dto;
        }

        /* <summary>
        Finds the current Entity via it's Id. If it's null, it returns null.
        If not, it will go the asyncronous Task above with the entity.
         </summary> */
        public new async Task<Dto> Delete(Guid id)
        {
            var entity = await GetById(id);
            if (entity != null) return await Delete(_mapper.Map<Dto>(entity));
            return null;
        }
    }
}
