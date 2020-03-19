using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerDtoCrudBase<CountryDto, IMappingRepository<CountryDto>>
    {
        private readonly IMappingRepository<CountryDto> _countryMapperRepo;
        public CountriesController(IMappingRepository<CountryDto> countryMapperRepo) : base(countryMapperRepo)
        {
            _countryMapperRepo = countryMapperRepo;
        }
    }
}
