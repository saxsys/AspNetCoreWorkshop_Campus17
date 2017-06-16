namespace ContentNegotiating
{
    public class Repository
    {
        public string Name { get; set; }

        public string[] ProgrammingLanguages { get; set; }

        public SourceFile[] SourceFiles { get; set; }
    }
}