using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;

namespace MovieShop.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateMovie(MovieCreateRequestModel movieCreateRequestModel)
        {
            // save to database
            return View();
        }

        [HttpGet]
        public IActionResult CreateMovie()
        {
            // will show empty page so that admin can enter movie information
            return View();
        }

    }
}
