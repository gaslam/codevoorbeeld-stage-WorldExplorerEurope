using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.VUE.ViewModels.Base;

namespace WorldExplorerEurope.VUE.ViewModels
{
    public class CountryViewModel : BaseId
    {
        public string Name { get; set; }

        [JsonProperty("flagUrl")]
        public Uri Flag { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }

        public ICollection<CountryFavourites> Favourites { get; set; }
        
        [JsonProperty("countryPhotoMemories")]
        public ICollection<CountryPhotoMemories> Memories { get; set; }
        public ICollection<CountryWishlists> CountryWishlists { get; set; }
    }
}
