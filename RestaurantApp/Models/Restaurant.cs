using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    //constructor
    public class Restaurant
    {
        
         
         public Restaurant(int Rank)
         {

           RestaurantRanking = Rank;
        }


        //ranking and is required

        [Required]
        public int RestaurantRanking { get; } 

        //name and is required
        [Required]
        public string RestaurantName { get; set; }

        //favorite dish not required and a nullable value set to it's tasty
        #nullable enable
        #nullable disable
        public string? FavDish { get; set; } = "It's all tasty!";
        string? nullable = default;
        

        //restaurant address and is required
        [Required]
        public string Address { get; set; }

        //phone number and not required
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        //link and not required. Also a nullable value set to coming soon
        #nullable enable
        #nullable disable
        public string? LinkToRestaurant { get; set; } = "Coming soon.";

        public static Restaurant[] GetRestaurant()
        {
            //creating a new instance of Band then returning the instance r1 -r5 for all the restaurants
            Restaurant r1 = new Restaurant(1)
            {
                //RestaurantRanking = 1,
               
                RestaurantName = "Cafe Rio Mexican Grill",
                //FavDish = "Sweet Pork Barbacoa Salad",
                Address = "2244 N University Pkwy, Provo, UT 84604",
                PhoneNumber = "(888)-660-1643",
                //LinkToRestaurant = "https://www.caferio.com/"


           };

          

            Restaurant r2 = new Restaurant(2)
            {
                //RestaurantRanking = 2,
                RestaurantName = "Bombay House",
                //FavDish = "Chicken Tikka Masala",
                Address = "463 N University Ave, Provo, UT 84604",
                PhoneNumber = "(801)-373-6677",
                //LinkToRestaurant = "https://bombayhouse.com/"


            };

            Restaurant r3 = new Restaurant(3)
            {
                //RestaurantRanking = 3,
                RestaurantName = "Molly's",
                //FavDish = "Fricasse Lemon Chicken",
                Address = "753 W. Columbia Lane, Provo, UT 84604",
                PhoneNumber = "(801)-374-3256",
                //LinkToRestaurant = "https://marvellouscatering.com/molly-s"


            };

            Restaurant r4 = new Restaurant(4)
            {
                //RestaurantRanking = 4,
                RestaurantName = "Black Sheep Cafe",
                //FavDish = "Fillet Mignon",
                Address = "19 N University Ave, Provo, UT 84601",
                PhoneNumber = "(801)-607-2485",
                //LinkToRestaurant = "https://blacksheepcafe.getbento.com/"


            };

            Restaurant r5 = new Restaurant(5)
            {
                //RestaurantRanking = 5,
                //r5.Rank = 5,
                RestaurantName = "Block Restaurant",
                //FavDish = "Block Burger",
                Address = "3330 N University Ave, Provo, UT 84604",
                PhoneNumber = "(801)-885-7758",
               // LinkToRestaurant = "https://blockrestaurantgroup.com/"


            };

            


            return new Restaurant[] { r1, r2, r3, r4, r5};
        }

        internal static IEnumerable<Restaurant> GetRestaurant2()
        {
            throw new NotImplementedException();
        }
    }

    
}
