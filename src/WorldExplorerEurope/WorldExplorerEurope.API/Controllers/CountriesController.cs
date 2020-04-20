﻿using System;
using System.Collections.Generic;
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
                var filename = await _memoryPhotoService.CreateImage(file, Guid.NewGuid());
                var memory = new PhotoMemory (){
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
    }
}
