using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//Home controller
namespace Restaurant4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> HomeRestaurantsList = new List<string>();

            foreach(HomeRestaurants r in HomeRestaurants.GetHomeRestaurants())
            {
                string? dish = r.FavoriteDish ?? "It's all tasty!";
                string? phone = r.PhoneNumber ?? "801-422-2526";
                HomeRestaurantsList.Add($"Ranked #{r.Rank}: <h4>{r.RestaurantName}</h4> <b>Favorite Dish: </b>{dish}<br> <b>Website: </b> <a href = '{r.Website}'> {r.Website}</a><br>   <b>Phone: </b> {phone}<br><br>");
            }

            return View(HomeRestaurantsList);
        }

        [HttpGet]
        public IActionResult SubmitRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitRestaurant(Restaurants SubmittedRestaurant)
        {
            TempStorage.AddRestaurant(SubmittedRestaurant);
            return View("Confirmation");
        }

        [HttpGet]
        public IActionResult ViewSubmissions()
        {
            return View(TempStorage.Restaurants);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
