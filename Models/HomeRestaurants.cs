using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Models for main page (top 5)


namespace Restaurant4.Models
{
    public class HomeRestaurants
    {
        public HomeRestaurants(int rank)
        {
            Rank = rank;
        }
        //Rank is a read only value
        public int Rank { get; }
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; }
        public string Address { get; set; }

        public string? PhoneNumber { get; set; }
        //The website null value is referenced here, in the model
        public string? Website { get; set; } = "Coming Soon.";



        public static HomeRestaurants[] GetHomeRestaurants()
        {
            HomeRestaurants r1 = new HomeRestaurants(1)
            {
                RestaurantName = "McDonalds",
                FavoriteDish = "McChicken",
                Address = "Provo",
                PhoneNumber = "801-374-6909",
                Website = "https://www.mcdonalds.com"
            };

            HomeRestaurants r2 = new HomeRestaurants(2)
            {
                RestaurantName = "Wendy's",
                FavoriteDish = "4 FOR 4",
                Address = "Provo",
                PhoneNumber = "801-377-8063",
                Website = "https://www.wendys.com"
            };

            HomeRestaurants r3 = new HomeRestaurants(3)
            {
                RestaurantName = "Bam Bams",
                Address = "Provo",
                PhoneNumber = "801-225-1324",
                Website = "https://www.bambamsbbq.com"
            };
            HomeRestaurants r4 = new HomeRestaurants(4)
            {
                RestaurantName = "Cafe Rio",
                Address = "Provo",
                PhoneNumber = "801-375-5133",
                Website = "https://www.caferio.com"
            };
            HomeRestaurants r5 = new HomeRestaurants(5)
            {
                RestaurantName = "Mo Bettahs",
                Address = "Provo",
                PhoneNumber = "801-784-6421"
                /*I left this website empty to show that the "coming soon" works*/
            };

            return new HomeRestaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
