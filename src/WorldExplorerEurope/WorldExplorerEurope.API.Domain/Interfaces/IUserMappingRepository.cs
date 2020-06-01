using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.Interfaces
{
    public interface IUserMappingRepository<Dto> where Dto : IdentityUser
    {
        Task<Dto> GetById(Guid Id);
        IQueryable<Dto> GetAll();
        Task<IEnumerable<Dto>> ListAll();
        IQueryable<Dto> GetSearchResults(Expression<Func<Dto, bool>> predicate);
        Task<Dto> Add(Dto Entity);
        Task<Dto> Update(Dto Entity);
        Task<Dto> Update(string id, Dto entity);
        Task<Dto> Delete(Guid id);
        Task<Dto> Delete(Dto Entity);
    }
}
