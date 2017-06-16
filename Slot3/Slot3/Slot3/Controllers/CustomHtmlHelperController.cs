using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class CustomHtmlHelperController : Controller
    {
        public IActionResult Index() => this.View();
    }
}