using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO;

namespace WorldExplorerEurope.API.Domain.Interfaces
{
    public interface IUserService
    {
        string GenerateToken(UserDto id);
    }
}
