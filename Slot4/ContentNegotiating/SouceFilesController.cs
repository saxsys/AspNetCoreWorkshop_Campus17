using Microsoft.AspNetCore.Mvc;

namespace ContentNegotiating
{
    [Route("sourcefiles")]
    public class SouceFilesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(string name, string author)
        {
            var sourceFile = new SourceFile { Name = name, Author = new Author { Name = author } };

            // TODO: Persist

            return this.Created("/SourceFiles/1", sourceFile.Name);
        }
    }
}