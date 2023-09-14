using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Func()
        {
            return View("salam");
        }

        public IActionResult Func2()
        {
            return View();
        }
    }
}
