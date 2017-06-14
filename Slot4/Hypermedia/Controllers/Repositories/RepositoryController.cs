using Halcyon.HAL;
using Hypermedia.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
                .AddLinks(this.GetLinks(name));
        }

        private IEnumerable<Link> GetLinks(string repoName)
        {
            yield return new Link(Link.RelForSelf, Localhost.Url($"/repositories/{repoName}"));

            if (this.User.Identity.IsAuthenticated)
            {
                yield return new Link("delete", Localhost.Url($"/repositories/{repoName}"), "Delete", "DELETE");
            }
        }
    }
}