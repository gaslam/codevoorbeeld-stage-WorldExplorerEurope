using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldExplorerEurope.VUE.services;

namespace WorldExplorerEurope.VUE.Controllers
{
    public class CountryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiService _apiService;

        protected const string baseUrl = "https://localhost:5001/api/countries";

        public CountryController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _apiService = new ApiService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("AddCountry")]
        public IActionResult AddCountry()
        {
            return View();
        }
    }
}