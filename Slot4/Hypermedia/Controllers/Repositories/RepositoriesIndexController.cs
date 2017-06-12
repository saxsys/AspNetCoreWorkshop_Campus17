using Halcyon.HAL;
using Hypermedia.Controllers.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hypermedia.Controllers
{
    [Route("repositories")]
    public class RepositoriesIndexController : ControllerBase
    {
        [HttpGet("")]
        public HALResponse Index()
        {
            var listRepresentation = new RepositoyListRepresentation
            {
                Repositories = Enumerable.Range(0, 10).Select(_ => new RepositoryRepresentation { Name = $"Repository {_}" }).ToList()
            };

            return new HALResponse(listRepresentation)
                   .AddLinks(new[]
                   {
                       new Link(Link.RelForSelf, Localhost.Url("/repositories"), "Repositories")
                   });
        }
    }
}