using Microsoft.AspNetCore.Mvc;

namespace EFAssignment2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
