using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Helpers;

namespace WorldExplorerEurope.API.Services
{
    public class AuthenticationService
    {
        private readonly WorldExplorerContext _worldExplorerContext;
        private readonly AppSettings _appSettings;

        public AuthenticationService(IOptions<AppSettings> settings, WorldExplorerContext worldExplorerContext)
        {
            _worldExplorerContext = worldExplorerContext;
            _appSettings = settings.Value;
        }
    }
}
