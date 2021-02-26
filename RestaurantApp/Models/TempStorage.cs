using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class TempStorage
    {
        private static List<AddRestaurant> restaurants = new List<AddRestaurant>();

        public static IEnumerable<AddRestaurant> Restaurants => restaurants;

        public static void AddApplication(AddRestaurant restaurant)
        {

            restaurants.Add(restaurant);

        }

    }
}
