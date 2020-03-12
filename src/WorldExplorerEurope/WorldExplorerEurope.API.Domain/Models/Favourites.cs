using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Favourite : EntityBase
    {
        public Guid CountryId { get; set; }

        [JsonIgnore]
        public ICollection<UserFavourites> Favourites { get; set; }
    }
}
