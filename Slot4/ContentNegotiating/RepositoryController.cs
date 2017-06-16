using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ContentNegotiating
{
    public class RepositoryController : ControllerBase
    {
        public IEnumerable<Repository> Index()
        {
            return 
                Enumerable
                .Range(0, 10)
                .Select(_ => new Repository
                {
                    Name = $"Repo {_}",
                    ProgrammingLanguages = new[] { "F#", "C#" },
                    SourceFiles = new []
                    {
                        new SourceFile { Name = "file1.fs" },
                        new SourceFile { Name = "file2.cs" }
                    }
                });
        }
    }
}