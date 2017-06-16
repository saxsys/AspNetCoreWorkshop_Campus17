using Microsoft.AspNetCore.Mvc;

namespace ContentNegotiating
{
    [Route("sourcefiles")]
    public class SouceFilesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(SourceFile sourceFile)
        {
            // TODO: Persist

            return this.Created("/SourceFiles/1", sourceFile.Name);
        }
    }
}