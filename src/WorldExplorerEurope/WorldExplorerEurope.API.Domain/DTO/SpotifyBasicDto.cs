using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO.Bases;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class SpotifyBasicDto
    {
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
        public string Searchterm { get; set; }
        public SimplePlaylist Playlist { get; set; }
        public Uri Url { get; set; }
    }
}
