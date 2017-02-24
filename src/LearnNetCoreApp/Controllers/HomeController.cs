using System.Collections.Generic;
using LearnNetCoreApp.Entities;
using LearnNetCoreApp.Services;
using LearnNetCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LearnNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                Restaurants = _restaurantData.GetAll(),
                CurrentMessage = _greeter.GetGreeting()
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
