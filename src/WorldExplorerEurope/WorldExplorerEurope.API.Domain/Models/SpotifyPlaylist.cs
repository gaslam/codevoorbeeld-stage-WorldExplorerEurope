using SpotifyAPI.Web.Models;
using System;

namespace WorldExplorerEurope.API.Domain.Models
{
    public class SpotifyPlaylist : EntityBase
    {
        public Guid CountryId { get; set; }
        public string PlaylistId { get; set; }
    }
}
