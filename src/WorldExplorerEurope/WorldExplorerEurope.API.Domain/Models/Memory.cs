using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class PhotoMemory : EntityBase
    {
        public Guid UserId { get; set; }
        public string FileName { get; set; }

        [JsonIgnore]
        public ICollection<CountryPhotoMemories> Memories { get; set; }
    }
}
