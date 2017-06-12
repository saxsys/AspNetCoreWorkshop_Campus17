using System.Collections.Generic;

namespace Hypermedia.Services
{
    public static class SourceFilesService
    {
        private static IEnumerable<string> sourceFiles;

        static SourceFilesService()
        {
            sourceFiles = new []
            {
                "file1.fs",
                "file2.fs",
                "file3.fs",

                "file1.cs",
                "file2.cs",
                "file3.cs",
                "file4.cs",

                "file1.ps1",
                "file2.ps1",
                "file3.ps1",
                "file4.ps1",

                "file1.sh",
                "file2.sh",
                "file3.sh",
                "file4.sh",

                "file1.md",
                "file2.md",
                "file3.md",
                "file4.md",

                "file1.html",
                "file2.html",
                "file3.html",
                "file4.html",
            };
        }

        public static IEnumerable<string> Get => sourceFiles;
    }
}