using System.Collections.Generic;

namespace Hypermedia.Controllers.Repositories
{
    public class RepositoyListRepresentation
    {
        public IEnumerable<RepositoryRepresentation> Repositories { get; set; }
    }
}