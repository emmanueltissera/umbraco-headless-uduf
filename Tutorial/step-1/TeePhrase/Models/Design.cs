using System.Collections.Generic;
using Umbraco.Headless.Client.Net.Models;
using Umbraco.Headless.Client.Net.Models.Umbraco;

namespace TeePhrase.Models
{
    public class Design : ContentBase
    {
        public string Description { get; set; }
        public List<Image> Photos { get; set; }
        public string Phrase { get; set; }
        public string Price { get; set; }
        public string ReferenceNumber { get; set; }
        public Image Thumbnail { get; set; }
        public string WhoSaidThis { get; set; }
    }
}
