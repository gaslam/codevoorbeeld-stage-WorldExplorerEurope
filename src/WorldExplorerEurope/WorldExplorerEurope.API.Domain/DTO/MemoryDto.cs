using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class MemoryDto : DtoBaseId
    {
        public ICollection<UserMemories> Memories { get; set; }
    }
}
