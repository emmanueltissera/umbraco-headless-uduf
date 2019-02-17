using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeePhrase.Models;
using Umbraco.Headless.Client.Net.Services;
using Umbraco.Headless.Client.Net.Web;

namespace TeePhrase.Controllers
{
    public class HomeController : BaseContentItemController
    {
        public HomeController(UmbracoContext umbracoContext, PublishedContentService publishedContentService) : base(umbracoContext, publishedContentService)
        {
        }

        public override Task<IActionResult> Index()
        {
            return RenderContentItem<Home>();
        }

    }

}
