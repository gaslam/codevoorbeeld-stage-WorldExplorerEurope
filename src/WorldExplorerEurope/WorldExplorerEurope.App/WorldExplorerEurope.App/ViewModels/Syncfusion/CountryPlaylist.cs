using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.App.ViewModels.Syncfusion
{
    public class CountryPlaylist
    {
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
        public string PlaylistId { get; set; }
        public List<CountryTracks> Playlist { get; set; } = new List<CountryTracks>();
        public Uri Url { get; set; }
    }
}
