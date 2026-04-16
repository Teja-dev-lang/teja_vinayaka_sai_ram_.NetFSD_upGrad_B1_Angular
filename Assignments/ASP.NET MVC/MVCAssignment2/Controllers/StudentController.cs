using Microsoft.AspNetCore.Mvc;
using MVCAssignment2.Models;

namespace MVCAssignment2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to Student Page");
        }

        public IActionResult Details(string name,int age)
        {
            ViewBag.name = name;
            ViewData["age"] = age;
            //return Content("Student Detail Page");
            return View();
        }

        public IActionResult GetStudent(int id)
        {
            return Content("Student ID is " + id);
        }

        public IActionResult StudentDetails()
        {
            var student = new List<Student>
            {
                new Student { Id = 1, Name = "Teja", Age = 22, Email = "teja@gmail.com" },
                new Student { Id = 2, Name = "Ravi", Age = 23, Email = "ravi@gmail.com" }
            };
            return View(student);
        }
    }
}
