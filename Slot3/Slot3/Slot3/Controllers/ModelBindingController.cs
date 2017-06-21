using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person { Firstname = "Campus", Lastname = "Workshop" };

            return this.View(person);
        }
    }
}