using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Wishlist : EntityBase
    {
        public Guid UserId { get; set; }

        [JsonIgnore]
        public ICollection<CountryWishlists> Wishlists { get; set; }
    }
}
