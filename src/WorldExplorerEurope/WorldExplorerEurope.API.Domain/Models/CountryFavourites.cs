using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class CountryFavourites
    {
        public Guid CountryId { get; set; }
        public Guid FavouriteId { get; set; }
        public Country Country { get; set; }
        public Favourite Favourite { get; set; }
    }
}
