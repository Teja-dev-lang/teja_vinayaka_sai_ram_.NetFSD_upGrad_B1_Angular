using Microsoft.AspNetCore.Mvc;
using MVCAssignment2.Models;
using MVCAssignment2.Repository;
namespace MVCAssignment2.Controllers
{
    public class StudentOperationsController : Controller
    {
        private readonly IStudentRepository _repo;
        public StudentOperationsController()
        {
            _repo = new StudentRepository();
        }
        public IActionResult Index()
        {
            var Getall = _repo.GetAllStudent();
            return View(Getall);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.AddStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View(student);
            }
        }
        public IActionResult Edit(int id)
        {
            _repo.UpdateStudent()
        }
        public IActionResult Delete(int id)
        {
            var student = _repo.GetAllStudent().FirstOrDefault(e => e.Id == id);
            if (student != null)
            {

            }
        }
    }
}
