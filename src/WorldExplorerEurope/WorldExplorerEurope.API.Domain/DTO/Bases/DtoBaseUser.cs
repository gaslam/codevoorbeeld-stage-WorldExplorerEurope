using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.DTO.Bases
{
    public abstract class DtoBaseUser
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
