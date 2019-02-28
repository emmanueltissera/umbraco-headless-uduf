using System.Linq;
using Newtonsoft.Json.Linq;
using Umbraco.Headless.Client.Net.Models;
using Umbraco.Headless.Client.Net.Models.Umbraco;
using Umbraco.Headless.Client.Net.Web.Configuration;

namespace TeePhrase.Extensions
{
    public static class MediaExtensions
    {
        public static string FullUrl(this Image image)
        {
            var fullPath = "https://emmanuels-faithful-sloth.s1.umbraco.io" + image.Url;
            return fullPath;
        }
    }
}
