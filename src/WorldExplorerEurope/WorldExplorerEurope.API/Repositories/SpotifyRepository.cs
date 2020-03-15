using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Repositories
{
    public class SpotifyRepository : Repository<SpotifyPlaylist>
    {
        private readonly WorldExplorerContext _worldExplorerContext;
        public SpotifyRepository(WorldExplorerContext worldExplorerContext) : base(worldExplorerContext)
        {
            _worldExplorerContext = worldExplorerContext;
        }
    }
}
