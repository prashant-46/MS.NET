using Microsoft.AspNetCore.Mvc;

namespace ModuleEndExam.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeLogin()
        {
            return View();
        }

        public IActionResult EmployeeSignup()
        {
            return View();
        }
    }
}
