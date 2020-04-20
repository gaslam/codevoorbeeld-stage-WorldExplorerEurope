using System;
using System.Collections;
using System.Collections.Generic;
using WorldExplorerEurope.API.Domain.DTO;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class Country : EntityBase
    {
        public string Name { get; set; }
        public Uri Flag { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }

        public ICollection<CountryFavourites> Favourites { get; set; }
        public ICollection<CountryPhotoMemories> Memories { get; set; }
        public ICollection<CountryWishlists> CountryWishlists { get; set; }
    }
}
