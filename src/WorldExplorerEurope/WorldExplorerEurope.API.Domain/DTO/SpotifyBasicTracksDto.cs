using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class SpotifyBasicTracksDto
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Artists { get; set; }
        public Uri PreviewUrl { get; set; }
    }
}
