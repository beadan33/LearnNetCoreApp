using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnNetCoreApp.Entities;

namespace LearnNetCoreApp.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly IEnumerable<Restaurant> _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "St-Hubert"},
                new Restaurant {Id = 2, Name = "Subway"},
                new Restaurant {Id = 3, Name = "La Casa Grecques"}
            };


        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }
    }
}
