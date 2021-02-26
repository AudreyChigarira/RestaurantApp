using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
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
            //create a list of a string type 
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurant())
            {
                 
                //allowing null values so program does not break
                int rank = r.RestaurantRanking;
                string? name = r.RestaurantName;
                string? address = r.Address;
                string? dish = r.FavDish;
                string? phone = r.PhoneNumber;
                string? link = r.LinkToRestaurant;

                //formatting the string output 
                restaurantList.Add(string.Format("{0}: {1} \n\n {2} \n\n {3} \n\n {4} \n\n ({5})", r.RestaurantRanking,
                r.RestaurantName, r.FavDish, r.Address, r.PhoneNumber, r.LinkToRestaurant));

            }
                //so we'll return the restaurant list that we created
                return View(restaurantList);
        }

         //for adding user's own restaurant
        [HttpGet]
        public IActionResult AddRestaurant()

        {
            return View();
        }

        //show user the confirmation page upon successful information entry

        [HttpPost]
        public IActionResult AddRestaurant(AddRestaurant addRestaurant)

        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempStorage.AddApplication(addRestaurant);
            return View("Confirmation");
        }

     
        //show the user their entry on the view restaurant page
        public IActionResult ViewRestaurant()

        {
            return View(TempStorage.Restaurants);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
