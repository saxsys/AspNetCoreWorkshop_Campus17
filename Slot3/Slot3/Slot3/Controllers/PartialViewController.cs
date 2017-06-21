using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index() => this.View();
    }
}