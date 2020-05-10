using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class CountryWishlists
    {
        public Guid CountryId { get; set; }
        public Guid WishlistId { get; set; }
        public Country Country { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}
