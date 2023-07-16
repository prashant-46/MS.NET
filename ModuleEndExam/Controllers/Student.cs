using Microsoft.AspNetCore.Mvc;

namespace ModuleEndExam.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentLogin()
        {
            return View();
        }

        public IActionResult StudentSignup()
        {
            return View();
        }

    }
}
