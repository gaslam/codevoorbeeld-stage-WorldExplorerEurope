using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Favourite : EntityBase
    {
        public Guid UserId { get; set; }

        [JsonIgnore]
        public ICollection<CountryFavourites> Favourites { get; set; }
    }
}
