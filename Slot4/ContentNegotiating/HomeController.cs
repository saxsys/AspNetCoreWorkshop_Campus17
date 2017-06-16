using Microsoft.AspNetCore.Mvc;

namespace ContentNegotiating
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index() => this.Content("Hello World");
    }
}