using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class PhotoMemoryDto : DtoBaseId
    {
        public Guid UserId { get; set; }
        public string FileName { get; set; }
        public ICollection<PhotoMemoryDto> PhotoMemories { get; set; }
    }
}
