using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.App.Services
{
    public class WorldExplorerAPIService
    {
        private readonly string _baseUrl;

        public WorldExplorerAPIService()
        {
            _baseUrl = "http:\\192.168.125.225:5000";
        }
    }
}
