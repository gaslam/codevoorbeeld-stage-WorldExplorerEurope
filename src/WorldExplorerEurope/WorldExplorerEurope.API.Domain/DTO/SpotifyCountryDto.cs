using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Base;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class SpotifyCountryDto : DtoBaseCountry
    {
        public string Name { get; set; }
        public Uri FlagUrl { get; set; }
        public long Population { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public bool IsEUMember { get; set; }
        public string Description { get; set; }

        public SpotifyPlaylistDto SpotifyPlaylist { get; set; }
    }
}
