using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTheWay_App.Controllers.Trip
{
    public class TripController : Controller
    {
        public IActionResult Book()
        {
            return View();
        }

        public IActionResult GetPackages()
        {
            return View();
        }
    }
}
