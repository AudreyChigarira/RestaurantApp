using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class AddRestaurant
    {


        [Required]
        public string Name { get; set; }

        [Required]
        public string ResName { get; set; }

        [Required]
        public string Dish { get; set; }

        //validating if phone number is a 9 digit number
       
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
      
        public string RestaurantPhone { get; set; }       
       
    }
}
