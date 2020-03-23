using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Services;

namespace WorldExplorerEurope.API.Controllers
{
    [Route("api/countries/[controller]")]
    [ApiController]
    public class SpotifyPlaylistsController : ControllerDtoCrudBase<SpotifyPlaylistDto, IMappingRepository<SpotifyPlaylistDto>>
    {
        private readonly IMappingRepository<SpotifyPlaylistDto> _playlistMappingRepo;
        private static Spotify _spotify;

        public SpotifyPlaylistsController(IMappingRepository<SpotifyPlaylistDto> playlistMappingRepo) : base(playlistMappingRepo)
        {
            _playlistMappingRepo = playlistMappingRepo;
            _spotify = new Spotify();
        }
        /*
         <Summary>
            Checks if token for Spotify API is valid.
            For more info right click CheckClientCredentials and choose Go to Definition
         </Summary>
         */
        [HttpGet("check")]
        private async Task<IActionResult> CheckToken()
        {
            bool check = _spotify.CheckClientCredentials();
            if(check == false)
            {
                return BadRequest("Could not validate credentials");
            }
            return Ok();
        }
    }
}