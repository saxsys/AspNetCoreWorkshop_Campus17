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
                    new Link("repositories", Localhost.Url("/repositories"), "Repositories")
                });
        }
    }
}