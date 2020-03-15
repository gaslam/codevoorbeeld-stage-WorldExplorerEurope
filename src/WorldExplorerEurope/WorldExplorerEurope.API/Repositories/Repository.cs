using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly WorldExplorerContext _worldExplorerContext;
        public Repository(WorldExplorerContext worldExplorerContext)
        {
            _worldExplorerContext = worldExplorerContext
        }
    }
}
