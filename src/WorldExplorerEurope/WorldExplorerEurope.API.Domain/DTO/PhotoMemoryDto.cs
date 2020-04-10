using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class PhotoMemoryDto : DtoBaseId
    {
        public ICollection<CountryPhotoMemories> Memories { get; set; }
    }
}
