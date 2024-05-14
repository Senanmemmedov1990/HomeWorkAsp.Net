using Microsoft.AspNetCore.Mvc;

namespace HomeWorkASP.Net.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Senan";
            ViewBag.surname = "Memmedov";
            ViewBag.age = 33;
            ViewBag.country = "Mozambik";
            ViewBag.phoneNumber = +994708665341;

            return View();
        }
    }
}
