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
        private DataContext dbContext;
        public CatalogController(DataContext context)
        {
            dbContext = context;
        }


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
            dbContext.Cars.Add(car);
            dbContext.SaveChanges();

            //car.Id = 1;
            return Json(car);
        }

        [HttpGet]
        public IActionResult GetCatalog(){
            //read the list from the Database 
            var cars = dbContext.Cars.ToList();
            // send the list of cars
            return Json(cars);
        }

    }
}