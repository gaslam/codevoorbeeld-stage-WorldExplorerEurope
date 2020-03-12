using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Memory : EntityBase
    {
        public Guid CountryId { get; set; }
        public string FileName { get; set; }

        [JsonIgnore]
        public ICollection<UserMemories> Memories { get; set; }
    }
}
