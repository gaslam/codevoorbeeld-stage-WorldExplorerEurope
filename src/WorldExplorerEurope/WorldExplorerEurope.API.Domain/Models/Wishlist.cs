using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Wishlist : EntityBase
    {
        public Guid CountryId { get; set; }

        [JsonIgnore]
        public ICollection<UserWishlists> Wishlists { get; set; }
    }
}
