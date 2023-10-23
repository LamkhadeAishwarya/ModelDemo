using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }
       
    }
}
