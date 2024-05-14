using Microsoft.AspNetCore.Mvc;

namespace HomeWorkASP.Net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
