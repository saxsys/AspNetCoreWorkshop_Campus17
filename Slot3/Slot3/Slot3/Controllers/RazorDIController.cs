using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class RazorDIController : Controller
    {
        public IActionResult Index() => this.View();
    }
}