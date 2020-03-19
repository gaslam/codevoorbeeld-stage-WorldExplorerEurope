using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class SpotifyPlaylistDto : EntityBase
    {
        public Guid CountryId { get; set; }
        public string playlistId  { get; set; }
    }
}
