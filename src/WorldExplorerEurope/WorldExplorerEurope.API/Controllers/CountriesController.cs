using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Domain.Services;

namespace WorldExplorerEurope.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerDtoCrudBase<CountryDto, IMappingRepository<CountryDto>>
    {
        private readonly IMappingRepository<CountryDto> _countryMapperRepo;
        private readonly IRepository<Country> _countryRepo;
        private readonly IMemoryPhotoService _memoryPhotoService;
        private readonly WorldExplorerContext _worldExplorerContext;
        private readonly IMapper _mapper;
        public CountriesController(IMemoryPhotoService memoryPhotoService, WorldExplorerContext worldExplorerContext, IRepository<Country> countryRepo, IMappingRepository<CountryDto> repository, IMapper mapper) : base(repository)
        {
            _memoryPhotoService = memoryPhotoService;
            _worldExplorerContext = worldExplorerContext;
            _countryMapperRepo = repository;
            _mapper = mapper;
            _countryRepo = countryRepo;
        }

        /* [HttpGet("All")]
         public async Task<IActionResult> GetAll()
         {
             var countries = await _mappingRepository.ListAll();
             foreach(var country in countries)
             {
                var memro = _worldExplorerContext.Memories.Where(m => m.)
             }
         }*/

        [HttpPost("add")]
        public async Task<IActionResult> AddCountry([FromBody]CountryDto country)
        {
            var existingCountry = _countryMapperRepo.GetAll().FirstOrDefault(m => m.Name == country.Name);
            if (existingCountry != null)
            {
                return BadRequest("Country already exists");
            }

            try
            {
                await _countryMapperRepo.Add(country);
                return Ok(country);
            }
            catch
            {
                return BadRequest("country cannot be added");
            }
        }

        [HttpPost("{countryId}/{userId}/memory")]
        public async Task<IActionResult> PostPhotoMemory([FromRoute]Guid countryId, [FromRoute] Guid userId, IFormFile file)
        {
            var entity = await _mappingRepository.GetById(countryId);
            if (entity == null)
            {
                return NotFound($"Cannot find country with id: {countryId}!!");
            };
            try
            {
                var filename = await _memoryPhotoService.CreateImage(file, Guid.NewGuid(),nameof(Country).ToLower());
                var memory = new PhotoMemory()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    FileName = filename.ToString()
                };

                _worldExplorerContext.Memories.Add(memory);
                await _worldExplorerContext.SaveChangesAsync();

                entity.CountryPhotoMemories.Add(
                    new PhotoMemoryDto
                    {
                        Id = memory.Id,
                        FileName = memory.FileName,
                        UserId = userId
                    });

                return Ok(await _countryMapperRepo.Update(countryId.ToString(), entity));
            }
            catch
            {
                return BadRequest("Cannot save image!!");
            }
        }

        [HttpPost("{countryId}/{userId}/favourites")]
        public async Task<IActionResult> PostFavourite([FromRoute]Guid countryId, [FromRoute] Guid userId)
        {
            var entity = await _mappingRepository.GetById(countryId);
            if (entity == null)
            {
                return NotFound($"Cannot find country with id: {countryId}!!");
            };
            try
            {
                var favourite = new Favourite()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId
                };
                _worldExplorerContext.Favourites.Add(favourite);
                await _worldExplorerContext.SaveChangesAsync();
                var favouriteDto = new FavouritesDto()
                {
                    Id = favourite.Id,
                    UserId = userId,
                };
                entity.Favourites.Add(favouriteDto);
                return Ok(await _countryMapperRepo.Update(countryId.ToString(), entity));
            }
            catch
            {
                return BadRequest("Cannot save image!!");
            }
        }

        [HttpPost("{countryId}/{userId}/wishlist")]
        public async Task<IActionResult> PostWishlist([FromRoute]Guid countryId, [FromRoute] Guid userId)
        {
            var entity = await _mappingRepository.GetById(countryId);
            if (entity == null)
            {
                return NotFound($"Cannot find country with id: {countryId}!!");
            };
            try
            {
                var wishlist = new Wishlist()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId
                };
                _worldExplorerContext.Wishlists.Add(wishlist);
                await _worldExplorerContext.SaveChangesAsync();
                var wishlistDto = new WishlistDto()
                {
                    Id = wishlist.Id,
                    UserId = userId
                };
                entity.CountryWishlists.Add(wishlistDto);
                return Ok(await _countryMapperRepo.Update(countryId.ToString(), entity));
            }
            catch
            {
                return BadRequest("Cannot save image!!");
            }
        }

        [HttpDelete("favourites/remove/{countryId}/{favouriteId}")]
        public async Task<IActionResult> DeleteFavourite([FromRoute] Guid countryId, Guid favouriteId)
        {
            try
            {
                var entity = _worldExplorerContext.Favourites.SingleOrDefault(m => m.Id == favouriteId);
                if (entity == null)
                {
                    return NotFound($"Cannot find favourite with id: {favouriteId}!!");
                };
                _worldExplorerContext.Favourites.Remove(entity);
                await _worldExplorerContext.SaveChangesAsync();
                var country = await _mappingRepository.GetById(countryId);
                country.Favourites.Remove(country.Favourites.FirstOrDefault(m => m.Id == favouriteId));
                return Ok(await _countryMapperRepo.Update(countryId.ToString(), country));
            }
            catch
            {
                return BadRequest("Cannot delete favourite!!");
            }
        }


        [HttpDelete("wishlists/remove/{countryId}/{wishlistId}")]
        public async Task<IActionResult> DeleteWishlist([FromRoute] Guid countryId, Guid wishlistId)
        {
            try
            {
                var entity = _worldExplorerContext.Wishlists.SingleOrDefault(m => m.Id == wishlistId);
                if (entity == null)
                {
                    return NotFound($"Cannot find wishlist with id: {wishlistId}!!");
                };
                _worldExplorerContext.Wishlists.Remove(entity);
                await _worldExplorerContext.SaveChangesAsync();
                var country = await _mappingRepository.GetById(countryId);
                country.CountryWishlists.Remove(country.CountryWishlists.FirstOrDefault(m => m.Id == wishlistId));
                return Ok(await _countryMapperRepo.Update(countryId.ToString(), country));
            }
            catch
            {
                return BadRequest("Cannot delete favourite!!");
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCountry([FromRoute]Guid countryId, [FromRoute] Guid userId, IFormFile file)
        {
            var entity = await _mappingRepository.GetById(countryId);
            if (entity == null)
            {
                return NotFound($"Cannot find country with id: {countryId}!!");
            };
            try
            {
                var filename = await _memoryPhotoService.CreateImage(file, Guid.NewGuid(), "flags");

                return Ok(await _countryMapperRepo.Update(countryId.ToString(), entity));
            }
            catch
            {
                return BadRequest("Cannot save image!!");
            }
        }

        [HttpPost("/{countryName}flag")]
        public async Task<IActionResult> UploadFlag([FromRoute] string countryName, IFormFile flag)
        {
            var existingCountry = _countryMapperRepo.GetAll().FirstOrDefault(m => m.Name.ToLower() == countryName.ToLower());
            if (existingCountry != null)
            {
                return BadRequest("Country already exists");
            }
            if (Path.GetExtension(flag.FileName) != ".svg")
            {
                return BadRequest($"{Path.GetExtension(flag.FileName)} is not a valid extension. Only svg's are accepted.");
            }
            Uri url = await _memoryPhotoService.CreateImage(flag, Guid.NewGuid(), "flags");
            if(url == null)
            {
                return BadRequest("Cannot add image");
            }
            return Ok(url);
        }

        [HttpPut("{countryName}/flag/update")]
        public async Task<IActionResult> UpdateFlag([FromRoute] string countryName, IFormFile flag)
        {
            var existingCountry = _countryMapperRepo.GetAll().FirstOrDefault(m => m.Name.ToLower() == countryName.ToLower());
            if (existingCountry == null)
            {
                return NotFound("Country not found");
            }
            if (Path.GetExtension(flag.FileName) != ".svg")
            {
                return BadRequest($"{Path.GetExtension(flag.FileName)} is not a valid extension. Only svg's are accepted.");
            }
            Uri url = await _memoryPhotoService.CreateImage(flag, Guid.NewGuid(), "flags");
            if (url == null)
            {
                return BadRequest("Cannot add image");
            }
            return Ok(url);
        }
    }
}
