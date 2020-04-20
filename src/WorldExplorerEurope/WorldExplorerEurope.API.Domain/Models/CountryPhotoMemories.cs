using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class CountryPhotoMemories
    {
        public Guid CountryId { get; set; }
        public Guid MemoryId { get; set; }
        public Country Country { get; set; }
        public PhotoMemory Memory { get; set; }
    }
}
