using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class UserMemoriesDto : EntityBase
    {
        public Guid UserId { get; set; }
        public ICollection<PhotoMemoryDto> Memories { get; set; }
    }
}
