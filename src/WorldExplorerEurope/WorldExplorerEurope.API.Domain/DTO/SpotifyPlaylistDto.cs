using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class SpotifyPlaylistDto : DtoBaseId
    {
        public Guid CountryId { get; set; }
        public string PlaylistId { get; set; }
    }
}
