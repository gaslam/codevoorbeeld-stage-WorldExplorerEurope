using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IRepository<Country> _countryRepo;
        public CountriesController(IRepository<Country> countryRepo)
        {
            _countryRepo = countryRepo;
        }
    }
}
