using Umbraco.Headless.Client.Net.Models;

namespace TeePhrase.Models
{
    public class UniqueSellingPoint : ContentItem, IContentBase
    {
        public IContentBase ButtonLink { get; set; }
        public string ButtonTitle { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
    }
}
