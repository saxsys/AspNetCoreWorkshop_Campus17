using System.Collections.Generic;

namespace ContentNegotiating
{
    public class Repository
    {
        public string Name { get; set; }

        public IEnumerable<string> ProgrammingLanguages { get; set; }

        public IEnumerable<SourceFile> SourceFiles { get; set; }
    }
}