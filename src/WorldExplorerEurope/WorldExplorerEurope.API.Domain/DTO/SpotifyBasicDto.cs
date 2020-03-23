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
        public string PlaylistId { get; set; }
        public List<SpotifyBasicTracksDto> Top5Tracks { get; set; }
        public Uri Url { get; set; }
    }
}
