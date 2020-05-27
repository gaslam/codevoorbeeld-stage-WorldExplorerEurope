using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WorldExplorerEurope.VUE.services;
using WorldExplorerEurope.VUE.ViewModels;

namespace WorldExplorerEurope.VUE.Controllers
{
    public class SpotifyDjController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiService _apiService;

        protected const string baseUrl = "https://localhost:5001/api/countries";

        public SpotifyDjController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _apiService = new ApiService();
        }
        [Route("SpotifyDj")]
        [Route("SpotifyDj/index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("editPlaylist/{playlist}")]
        public IActionResult EditPlaylist(string playlist)
        {
            PlaylistId playlistId = new PlaylistId();
            playlistId.id = playlist;
            return View(playlistId);
        }
    }
}
