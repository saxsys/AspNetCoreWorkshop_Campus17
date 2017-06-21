using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class NoModelBindingController : Controller
    {
        // Usually that is a POST
        public IActionResult Index(string firstname, string lastname)
        {
            var person = new Person { Firstname = firstname, Lastname = lastname };

            return this.View(person);
        }
    }
}