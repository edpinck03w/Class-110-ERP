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
        
    }
}