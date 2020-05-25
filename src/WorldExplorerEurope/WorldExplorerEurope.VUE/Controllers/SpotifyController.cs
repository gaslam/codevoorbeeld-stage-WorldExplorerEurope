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
    public class SpotifyController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiService _apiService;

        protected const string baseUrl = "https://localhost:5001/api/countries";

        public SpotifyController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _apiService = new ApiService();
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }

        [Route("UserDetails/{id}")]
        public async Task<IActionResult> UserDetails(Guid id)
        {
            var userDetails = await _apiService.Get($"{baseUrl}/users/{id}");
            var user = JsonConvert.DeserializeObject<SpotifyViewModel>(userDetails);
            if (user == null)
            {
                return Content("User not found");
            }
            return View(user);
        }

        [Route("EditUser/{id}")]
        public IActionResult EditUser(Guid id)
        {
            return View(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
