using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnNetCoreApp.Entities;

namespace LearnNetCoreApp.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
