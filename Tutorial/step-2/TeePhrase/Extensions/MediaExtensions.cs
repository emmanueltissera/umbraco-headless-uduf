using Umbraco.Headless.Client.Net.Models.Umbraco;

namespace TeePhrase.Extensions
{
    public static class MediaExtensions
    {
        public static string FullUrl(this Image image)
        {
            // TODO: Get base path from configuration (or wait for Headless Client update)
            var fullPath = "https://emmanuels-faithful-sloth.s1.umbraco.io" + image.Url;
            return fullPath;
        }
    }
}
