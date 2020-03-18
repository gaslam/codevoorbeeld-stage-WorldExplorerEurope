using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class MemoryDto : DtoBaseId
    {
        public string FileName { get; set; }
    }
}
