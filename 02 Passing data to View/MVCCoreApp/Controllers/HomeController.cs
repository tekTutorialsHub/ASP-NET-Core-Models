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

        public IActionResult Index()
        {
            ViewBag.Customer = new Customer();
            return View();
        }

        public IActionResult Method1()
        {
            ViewData.Model = new Customer(); 
            return View();
        }


        public IActionResult StrongView()
        {
            ViewData.Model = new Customer();
            return View();
        }


        public IActionResult CorrectWay()
        {
            Customer customer = new Customer();
            return View(customer);
        }

    }
}