using System.Collections.Generic;

namespace Hypermedia.Services
{
    public static class ProgrammingLanguagesService
    {
        private static IEnumerable<string> programmingLanguages;

        static ProgrammingLanguagesService()
        {
            programmingLanguages = new[]
            {
                "F#",
                "C#",
                "Powershell",
                "HTML",
                "Markdown",
                "Bash"
            };
        }

        public static IEnumerable<string> Get => programmingLanguages;
    }
}