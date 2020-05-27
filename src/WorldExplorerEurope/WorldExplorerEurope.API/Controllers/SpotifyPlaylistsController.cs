using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Services;

namespace WorldExplorerEurope.API.Controllers
{
    [Authorize]
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
        [AllowAnonymous]
        [HttpGet("check")]
        public async Task<IActionResult> CheckToken()
        {
            bool check = _spotify.CheckClientCredentials().Result;
            if (check == false)
            {
                return BadRequest("Credentials not valid!!");
            }
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("basic")]
        public async Task<IActionResult> GetBasicSpotifyPlaylists()
        {
            var playlists = _mappingRepository.GetAll();
            var countries = _worldExplorerContext.Countries.ToList();
            List<SpotifyBasicDto> spotifyBasicDtos = new List<SpotifyBasicDto>();
            foreach (var playlist in playlists)
            {
                var country = countries.FirstOrDefault(m => m.Id == playlist.CountryId);
                SpotifyBasicDto spotifyBasicDto = new SpotifyBasicDto()
                {
                    CountryId = country.Id,
                    CountryName = country.Name,
                    PlaylistId = playlist.PlaylistId,
                    Url = new Uri($"https://open.spotify.com/playlist/{playlist.PlaylistId}"),
                    Playlist = new List<SpotifyBasicTracksDto>()
                };
                spotifyBasicDtos.Add(spotifyBasicDto);
            }
            return Ok(spotifyBasicDtos);
        }

        [AllowAnonymous]
        [HttpGet("playlists/{id}")]
        public async Task<IActionResult> GetBasicSpotifyPlaylist([FromRoute] Guid id)
        {
            var playlist = await _mappingRepository.GetById(id);
            if (playlist == null)
            {
                return NotFound($"Playlist with id: {id} is not valid.");
            }

            var fullplaylist = await _spotify.GetFullPlaylist(playlist.PlaylistId);
            var tracks = await _spotify.GetFirst5Tracks(fullplaylist);
            var country = getCountry(playlist.CountryId);

            SpotifyBasicDto spotifyBasicDto = new SpotifyBasicDto()
            {
                CountryId = country.Id,
                CountryName = country.Name,
                PlaylistId = playlist.PlaylistId,
                Url = new Uri($"https://open.spotify.com/playlist/{playlist.PlaylistId}")
            };
            spotifyBasicDto.Playlist = new List<SpotifyBasicTracksDto>();
            foreach (var track in tracks)
            {
                spotifyBasicDto.Playlist.Add(
                    new SpotifyBasicTracksDto
                    {
                        Artists = track.Artists,
                        Number = track.Number,
                        Name = track.Name,
                        PreviewUrl = track.PreviewUrl
                    });
            }
            return Ok(spotifyBasicDto);
        }

        [AllowAnonymous]
        [HttpGet("playlists/Country/{id}")]
        public async Task<IActionResult> GetCountryPlaylist([FromRoute] Guid id)
        {
            bool check = _spotify.CheckClientCredentials().Result;
            if (check == true)
            {
                var playlist = _mappingRepository.GetAll().FirstOrDefault(m => m.CountryId == id);
                if (playlist == null)
                {
                    return NotFound($"Playlist with id: {id} is not valid.");
                }

                var fullplaylist = await _spotify.GetFullPlaylist(playlist.PlaylistId);
                var tracks = await _spotify.GetFirst5Tracks(fullplaylist);
                var country = getCountry(playlist.CountryId);

                SpotifyBasicDto spotifyBasicDto = new SpotifyBasicDto()
                {
                    CountryId = country.Id,
                    CountryName = country.Name,
                    PlaylistId = playlist.PlaylistId,
                    Url = new Uri($"https://open.spotify.com/playlist/{playlist.PlaylistId}")
                };
                spotifyBasicDto.Playlist = new List<SpotifyBasicTracksDto>();
                if (tracks != null)
                {
                    foreach (var track in tracks)
                    {
                        spotifyBasicDto.Playlist.Add(
                            new SpotifyBasicTracksDto
                            {
                                Artists = track.Artists,
                                Number = track.Number,
                                Name = track.Name,
                                PreviewUrl = track.PreviewUrl
                            });
                    }
                }
                return Ok(spotifyBasicDto);
            }
            return BadRequest("Service not availible");
        }
        [AllowAnonymous]
        [HttpGet("basic/{id}")]
        public IActionResult GetPlaylistByPlaylistId([FromRoute] string id)
        {
            var playlist = _mappingRepository.GetAll().SingleOrDefault(m => m.PlaylistId == id);
            if (playlist == null)
            {
                return NotFound($"Playlist with id: {id} is not valid.");
            }
            var countryname = _worldExplorerContext.Countries.FirstOrDefault(m => m.Id == playlist.CountryId).Name;
            SpotifyBasicDto entity = new SpotifyBasicDto();
            entity.Playlist = new List<SpotifyBasicTracksDto>();
            entity.PlaylistId = playlist.PlaylistId;
            entity.CountryId = playlist.CountryId;
            entity.CountryName = countryname;
            entity.Url = new Uri($"https://open.spotify.com/playlist/{playlist.PlaylistId}");
            return Ok(entity);
        }


        [Authorize]
        [HttpDelete("basic/{id}")]
        public IActionResult DeletePlaylistByPlaylistId([FromRoute] string id)
        {
            var playlist = _mappingRepository.GetAll().SingleOrDefault( m => m.PlaylistId == id);
            if (playlist == null)
            {
                return NotFound($"Playlist with id: {id} is not valid.");
            }
            var entity = _mappingRepository.Delete(playlist);
            if (entity == null)
            {
                return NotFound($"Playlist with id: {id} could not be deleted.");
            }
            return Ok(entity);
        }

        [Authorize]
        [HttpPut("basic/{id}")]
        public async Task<IActionResult> UpdatePlaylistByPlaylistId([FromRoute] string id, [FromBody] SpotifyBasicDto dto)
        {
            var playlist = _mappingRepository.GetAll().SingleOrDefault(m => m.PlaylistId == id);
            if (playlist == null)
            {
                return NotFound($"Playlist with id: {id} is not valid.");
            }

            playlist.PlaylistId = dto.PlaylistId;
            var entity = await _mappingRepository.Update(playlist);
            if (entity == null)
            {
                return NotFound($"Playlist with id: {id} could not be deleted.");
            }
            //return Ok(entity);
            return Ok();
        }

        private CountryDto getCountry(Guid countryId)
        {
            using (var webClient = new WebClient())
            {
                var baseUrl = $"https://localhost:5001/api/countries/{countryId}";
                string rawJSON = webClient.DownloadString(baseUrl);
                var country = JsonConvert.DeserializeObject<CountryDto>(rawJSON);
                return country;
            }
        }
    }
}