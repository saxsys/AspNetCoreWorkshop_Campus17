using Microsoft.AspNetCore.Mvc;

namespace Slot3.Controllers
{
    public class Person
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }

    public class ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person { Firstname = "Campus", Lastname = "Workshop" };

            return this.View(person);
        }
    }
}