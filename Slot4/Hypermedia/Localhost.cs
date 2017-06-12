namespace Hypermedia
{
    public static class Localhost
    {
        public static string Url(string relativeUrl) => $"http://localhost:28754{relativeUrl}";
    }
}