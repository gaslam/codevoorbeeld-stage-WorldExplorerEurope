using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Repositories.Base;

namespace WorldExplorerEurope.API.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly WorldExplorerContext _worldExplorerContext;

        public UserRepository(WorldExplorerContext worldExplorerContext) : base(worldExplorerContext)
        {
            _worldExplorerContext = worldExplorerContext;
        }
    }
}
