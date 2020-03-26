using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Data;
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
        private readonly WorldExplorerContext _worldExplorerContext;

        public SpotifyPlaylistsController(IMappingRepository<SpotifyPlaylistDto> playlistMappingRepo, WorldExplorerContext worldExplorerContext) : base(playlistMappingRepo)
        {
            _playlistMappingRepo = playlistMappingRepo;
            _spotify = new Spotify();
            _worldExplorerContext = worldExplorerContext;
        }
        /*
            <Summary>
            Checks if token for spotify API is valid.
            For more info, rightclick on CheckClientCredentials and click on Go To Definition.
            </Summary>
        */
        [HttpGet("check")]
        public async Task<IActionResult> CheckToken()
        {
            bool check = _spotify.CheckClientCredentials().Result;
            if(check == false)
            {
                return BadRequest("Credentials not valid!!");
            }
            return Ok();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetBasicSpotifyPlaylists()
        {
            var playlists = _mappingRepository.GetAll();
            List<SpotifyBasicDto> spotifyBasicDtos = new List<SpotifyBasicDto>();
            foreach (var playlist in playlists)
            {
                var spotifyPlaylist = _spotify.GetPlaylist(playlist.Searchterm);
                var spotifyPlaylistTracks = _spotify.GetTracks(playlist.Searchterm);
                var country = _worldExplorerContext.Countries.FirstOrDefault(m => m.Id == playlist.CountryId);
                spotifyBasicDtos.Add( new SpotifyBasicDto
                {
                    CountryId = playlist.CountryId,
                    CountryName = country.Name,
                    Url = new Uri(spotifyPlaylist.Result.Uri),
                    Searchterm = playlist.Searchterm,
                });
            }
            foreach(var playlist in spotifyBasicDtos)
            {
                var spotifyPlaylistTracks = _spotify.GetTracks(playlist.Searchterm);
                int number = 1;
                for(int i = 0; i > spotifyPlaylistTracks.Result.Tracks.Count; i++)
                {
                    playlist.Top5Tracks.Add(new SpotifyBasicTracksDto
                    {
                        Name = spotifyPlaylistTracks.Result.Tracks[i].Name,
                        Number = number,
                        PreviewUrl = new Uri(spotifyPlaylistTracks.Result.Tracks[i].PreviewUrl)
                    });
                }
            }
            return Ok(playlists);
        }
    }
}