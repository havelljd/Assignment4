using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant4.Models
{
    public class Restaurants
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavoriteDish { get; set; }
        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(1-)?\d{3}-\d{3}-\d{4}$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

    }
}
