using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddStudent(Student stud)
        {
            return View(stud);
        }
    }
}
