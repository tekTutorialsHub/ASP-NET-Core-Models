using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "hello from the Index method of the HomeController";
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            HomeModel message = new HomeModel();
            return View(message);
        }
    }
}