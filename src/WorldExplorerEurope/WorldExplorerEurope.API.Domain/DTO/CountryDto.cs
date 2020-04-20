using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class CountryDto : DtoBaseId
    {
        public string Name { get; set; }
        public Uri FlagUrl { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }

        public List<CountryFavourites> Favourites { get; set; }
        public ICollection<PhotoMemoryDto> CountryPhotoMemories { get; set; }
        public List<CountryWishlists> CountryWishlists { get; set; }
    }
}
