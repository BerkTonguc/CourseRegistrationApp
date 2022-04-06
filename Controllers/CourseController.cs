using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    
    public class CourseController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }

        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "ASP.NET MVC";
            course.Description = "Beginner to Advance";
            course.IsPublished = true;

            return View(course);
        }

       
        public IActionResult List()
        {
            var students = Repository.Students;
            return View(students);
        }
    }
}