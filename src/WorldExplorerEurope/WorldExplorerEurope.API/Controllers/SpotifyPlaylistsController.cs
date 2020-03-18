using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Controllers
{
    [Route("api/countries/[controller]")]
    [ApiController]
    public class SpotifyPlaylistsController : ControllerBase
    {
        private readonly IRepository<SpotifyPlaylist> _spotifyPlaylistRepo;

        public SpotifyPlaylistsController(IRepository<SpotifyPlaylist> spotifyPlaylistRepo)
        {
            _spotifyPlaylistRepo = spotifyPlaylistRepo;
        }
    }
}