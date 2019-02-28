using System.Collections.Generic;
using Umbraco.Headless.Client.Net.Models;
using Umbraco.Headless.Client.Net.Models.Umbraco;

namespace TeePhrase.Models
{
    public partial class Home : ContentBase
    {
        public List<Image> CarouselImages { get; set; }
        public string Lead { get; set; }
        public string PhraseSamples { get; set; }
        public string Title { get; set; }
        public List<UniqueSellingPoint> UniqueSellingPoints { get; set; }
    }
}
