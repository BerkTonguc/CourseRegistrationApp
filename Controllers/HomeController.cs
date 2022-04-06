using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    // localhost:5000
    // localhost:5000/home  
    public class HomeController : Controller
    {
        // localhost:5000/home/index => home/index.cshtml 
        public IActionResult Index()
        {
            int time = DateTime.Now.Hour;

            ViewBag.Greeting = "Welcome to the ASP.NET MVC 5 course registration page.";
            ViewBag.Message = "Message";

            return View();
        }

        // localhost:5000/home/about => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }
    }
}