using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.Interfaces
{
    public interface IUserService
    {
        string GenerateToken(User id);
    }
}
