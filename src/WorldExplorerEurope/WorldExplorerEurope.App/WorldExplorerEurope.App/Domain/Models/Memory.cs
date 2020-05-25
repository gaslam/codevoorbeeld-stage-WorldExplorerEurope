using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.App.Domain.Models
{
    public class PhotoMemoryDto : BaseId
    {
        public Guid UserId { get; set; }

        [JsonProperty("fileName")]
        public Uri PhotoName { get; set; }
    }
}
