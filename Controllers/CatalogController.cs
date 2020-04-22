using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ERP.Models;

namespace ERP.Controllers
{
    public class CatalogController : Controller 
    {
        // this is for /catalog/index
        // this is /catalog
        public IActionResult Index(){
            return View();
        }

        // this is for /catalog/register
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult SaveCar([FromBody] Car car ){

            System.Console.WriteLine("Saving new car");
            System.Console.WriteLine(car.Make);

            //save the car to the DB or database

            car.Id = 1;
            return Json(car);
        }

        [HttpGet]
        public IActionResult GetCatalog(){
            //read the list from the Database 
            // send the list of cars

            List<Car> cars = new List<Car>();
            var c1 = new Car();
            c1.Make = "Toyota";
            c1.Model = "Camry";
            c1.Year = 2003;

            cars.Add(c1);

            return Json(cars);
        }

    }
}