using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Models.Base;

namespace WorldExplorerEurope.Domain.Models
{
    public class Country : BaseId
    {
        public string Name { get; set; }
        public Uri FlagUrl { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }

        public List<Favourite> favourites { get; set; }
        public List<Memory> countryPhotoMemories { get; set; }
        public List<Wishlist> countryWishlists { get; set; }
    }
}
