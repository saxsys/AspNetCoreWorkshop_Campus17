using Hypermedia.DomainModel;
using System.Collections.Generic;

namespace Hypermedia.Services
{
    public class RepositoryService
    {
        private static IList<Repository> repositories;

        static RepositoryService()
        {
            repositories = new []
            {
                new Repository
                {
                    Name                 = "Repo_1",
                    ProgrammingLanguages = new [] 
                                           {
                                                "F#",
                                                "Markdown"
                                           },
                    SourceFiles          = new [] 
                                           {
                                                new SourceFile
                                                {
                                                    Name   = "file1.fs",
                                                    Author = new Author { Name = "Author 1" }
                                                },
                                                new SourceFile
                                                {
                                                    Name   = "file2.fs",
                                                    Author = new Author { Name = "Author 1" }
                                                },

                                                new SourceFile
                                                {
                                                    Name   = "file1.md",
                                                    Author = new Author { Name = "Author 2" }
                                                },
                                                new SourceFile
                                                {
                                                    Name   = "file2.md",
                                                    Author = new Author { Name = "Author 2" }
                                                },
                                           }
                },

                new Repository
                {
                    Name                 = "Repo_2",
                    ProgrammingLanguages = new []
                                           {
                                                "C#",
                                                "HTML"
                                           },
                    SourceFiles          = new []
                                           {
                                                new SourceFile
                                                {
                                                    Name   = "file1.cs",
                                                    Author = new Author { Name = "Author 1" }
                                                },
                                                new SourceFile
                                                {
                                                    Name   = "file2.cs",
                                                    Author = new Author { Name = "Author 1" }
                                                },

                                                new SourceFile
                                                {
                                                    Name   = "file1.html",
                                                    Author = new Author { Name = "Author 2" }
                                                },
                                                new SourceFile
                                                {
                                                    Name   = "file2.html",
                                                    Author = new Author { Name = "Author 2" }
                                                },
                                           }
                },

                new Repository
                {
                    Name                 = "Repo_3",
                    ProgrammingLanguages = new []
                                           {
                                                "F#",
                                                "Powershell"
                                           },
                    SourceFiles          = new []
                                           {
                                                new SourceFile
                                                {
                                                    Name   = "file1.fs",
                                                    Author = new Author { Name = "Author 1" }
                                                },
                                                new SourceFile
                                                {
                                                    Name   = "file2.fs",
                                                    Author = new Author { Name = "Author 1" }
                                                },

                                                new SourceFile
                                                {
                                                    Name   = "file1.ps1",
                                                    Author = new Author { Name = "Author 2" }
                                                },
                                                new SourceFile
                                                {
                                                    Name   = "file2.ps1",
                                                    Author = new Author { Name = "Author 2" }
                                                },
                                           }
                }
            };
        }

        public static IEnumerable<Repository> Get => repositories;
    }
}
