using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant4.Models
{
    public static class TempStorage
    {
        private static List<Restaurants> r = new List<Restaurants>();
        public static IEnumerable<Restaurants> Restaurants => r;
        public static void AddRestaurant(Restaurants restaurant)
        {
            r.Add(restaurant);
        }
    }
}