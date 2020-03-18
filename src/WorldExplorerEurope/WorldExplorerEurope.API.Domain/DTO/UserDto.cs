using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Base;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class UserDto : DtoBaseId
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
