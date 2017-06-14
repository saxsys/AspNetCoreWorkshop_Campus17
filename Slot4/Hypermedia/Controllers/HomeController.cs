using Halcyon.HAL;
using Microsoft.AspNetCore.Mvc;

namespace Hypermedia.Controllers
{
    public class HomeController : ControllerBase
    {
        public HALResponse Index()
        {
            return
                new HALResponse(null)
                .AddLinks(new[]
                {
                    new Link(Link.RelForSelf, Localhost.Url("/"), "Home"),

                    new Link("repositories", Localhost.Url("/repositories"), "Repositories"),

                    new Link("users", Localhost.Url("/users"), "Users"),

                    new Link("settings", Localhost.Url("/settings"), "Settings"),
                });
        }
    }
}