using EFAssignment2.DataBase;
using EFAssignment2.Entities;
using EFAssignment2.Models;
using EFAssignment2.ViewModel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace EFAssignment2.Controllers
{
    public class HomeController : Controller
    {
        public readonly StudentDbContext _context;
        public HomeController(StudentDbContext repo)
        {
            _context = repo;
        }
        public IActionResult Index()
        {
            var Enrol_course = (from s in _context.Students
                                join e in _context.Enrollments
                                    on s.StudentId equals e.StudentId
                                join c in _context.Courses
                                    on e.CourseId equals c.CourseId
                                select new StudentCourseViewModel
                                {
                                    StudentName = s.Name,
                                    CourseID = c.CourseId.ToString()
                                }).ToList();

            return View(Enrol_course);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
