using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Xml.Linq;
using System;
using Weather_App.Models;

namespace Weather_App.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            List<WeatherDatacs> weatherlist = new List<WeatherDatacs>()
            {
               new WeatherDatacs(){
                   CityUniqueCode = "LDN",
                   CityName = "London",
                   DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                   TemperatureFahrenheit = 33
                   },
               new WeatherDatacs(){
                   CityUniqueCode = "NYC",
                   CityName = "New York",
                   DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                   TemperatureFahrenheit = 60
                   },
               new WeatherDatacs(){
                   CityUniqueCode = "PAR", 
                   CityName = "Paris",
                   DateAndTime = DateTime.Parse("2030-01-01 9:00"), 
                   TemperatureFahrenheit = 82

                  }
            };

            return View(weatherlist);
        }
        [Route("/weather/{code}")]
        public IActionResult Cityweather(string ? code)
        {
            if (code == null)
                return Content("Person name can't be null");
            List<WeatherDatacs> weatherlist = new List<WeatherDatacs>()
            {
               new WeatherDatacs(){
                   CityUniqueCode = "LDN",
                   CityName = "London",
                   DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                   TemperatureFahrenheit = 33
                   },
               new WeatherDatacs(){
                   CityUniqueCode = "NYC",
                   CityName = "New York",
                   DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                   TemperatureFahrenheit = 60
                   },
               new WeatherDatacs(){
                   CityUniqueCode = "PAR",
                   CityName = "Paris",
                   DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                   TemperatureFahrenheit = 82

                  }
            };

            WeatherDatacs? matchingcity = weatherlist.Where(temp => temp.CityUniqueCode == code).FirstOrDefault();
            return View(matchingcity);
        }

    }
}
