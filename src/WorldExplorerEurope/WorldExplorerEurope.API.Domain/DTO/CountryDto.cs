using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Base;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class CountryDto : DtoBaseId
    {
        public string Name { get; set; }
    }
}
