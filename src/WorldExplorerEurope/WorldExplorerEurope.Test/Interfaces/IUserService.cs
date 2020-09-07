using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.Test.Interfaces
{
    public interface IUserService
    {
        string GenerateTokenApp(WorldExplorerEurope.App.Domain.Models.User id);
        string GenerateToken(User user);
    }
}
