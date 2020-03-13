using RestaurantTemplate.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantTemplate.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{RestaurantID = 1,Name = "Shalimar", Location = "Blankenbaker", Cuisine = CuisineType.Indian}
                ,new Restaurant{RestaurantID = 2,Name = "EiderDown", Location = "GermanTown", Cuisine = CuisineType.None}
                ,new Restaurant{RestaurantID = 3,Name = "Rament House", Location = "Bardstown", Cuisine = CuisineType.Japanese}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r; 
        }
    }
}
