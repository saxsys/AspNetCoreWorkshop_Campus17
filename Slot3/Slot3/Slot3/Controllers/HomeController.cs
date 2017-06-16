using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}