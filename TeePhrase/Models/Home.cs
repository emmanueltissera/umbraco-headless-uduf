using System.Collections.Generic;
using Umbraco.Headless.Client.Net.Models;

namespace TeePhrase.Models
{
    public partial class Home : ContentBase
    {
        public List<MediaItem> CarouselImages { get; set; }
        public string Lead { get; set; }
        public string PhraseSamples { get; set; }
        public string Title { get; set; }
        public List<UniqueSellingPoint> UniqueSellingPoints { get; set; }
    }
}
