using Halcyon.HAL;
using System.Collections.Generic;

namespace Hypermedia.Controllers.Repositories
{
    public class RepositoyListRepresentation
    {
        public IEnumerable<HALResponse> Repositories { get; set; }
    }
}