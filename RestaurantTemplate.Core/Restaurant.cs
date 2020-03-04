using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTemplate.Core
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
