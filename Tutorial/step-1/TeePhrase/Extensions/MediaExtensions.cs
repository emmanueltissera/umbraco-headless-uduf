using System.Linq;
using Newtonsoft.Json.Linq;
using Umbraco.Headless.Client.Net.Models;

namespace TeePhrase.Extensions
{
    public static class MediaExtensions
    {
        public static string Url(this MediaItem mediaItem)
        {
            var fileProperty = mediaItem.Properties.FirstOrDefault(t => t.Alias == "umbracoFile");

            var fileJObject  = (JObject) fileProperty?.Value;

            if (fileJObject == null)
            {
                return string.Empty;
            }

            var filePath = fileJObject.GetValue("src");
            var fullPath = "https://emmanuels-faithful-sloth.s1.umbraco.io" + filePath;
            return fullPath;
        }
    }
}
