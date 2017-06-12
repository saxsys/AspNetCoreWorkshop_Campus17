using Halcyon.HAL;
using Hypermedia.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;

namespace Hypermedia.Controllers.Repositories
{
    [Route("/repositories")]
    public class RepositoryController : ControllerBase
    {
        [HttpGet("{name}")]
        public HALResponse Item(string name)
        {
            var repo = RepositoryService.Get.FirstOrDefault(_ => _.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if(repo == null)
            {
                this.Response.StatusCode = (int)HttpStatusCode.NotFound;
                return
                    new HALResponse(null)
                    .AddLinks(new[]
                    {
                        new Link(Link.RelForSelf, Localhost.Url($"/repositories/{name}"))
                    });
            }

            var repoRepresentation = new RepositoryRepresentation
            {
                Name = repo.Name
            };

            return
                new HALResponse(repoRepresentation)
                .AddLinks(new[]
                {
                    new Link(Link.RelForSelf, Localhost.Url($"/repositories/{name}")),

                    new Link("delete", Localhost.Url($"/repositories/{name}"), "Delete", "DELETE")
                });
        }
    }
}