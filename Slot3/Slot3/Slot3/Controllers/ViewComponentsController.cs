using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class ViewComponentsController:Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}
