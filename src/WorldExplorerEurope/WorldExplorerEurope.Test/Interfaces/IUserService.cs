using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.App.Domain.Models;

namespace WorldExplorerEurope.Test.Interfaces
{
    public interface IUserService
    {
        string GenerateToken(User user);
    }
}
