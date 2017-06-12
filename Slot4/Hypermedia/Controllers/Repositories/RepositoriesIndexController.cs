using Halcyon.HAL;
using Hypermedia.Controllers.Repositories;
using Hypermedia.Services;
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
                Repositories = 
                    RepositoryService
                    .Get
                    .Select(_ => 
                        new HALResponse(
                            new RepositoryRepresentation
                            {
                                Name = _.Name
                            })
                            .AddLinks(new[]
                            {
                                new Link("item", Localhost.Url($"/repositories/{_.Name}"))
                            })
                        )
            };

            return new HALResponse(listRepresentation)
                   .AddLinks(new[]
                   {
                       new Link(Link.RelForSelf, Localhost.Url("/repositories"), "Repositories")
                   });
        }
    }
}