using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TeePhrase.Models;
using Umbraco.Headless.Client.Net.Services;
using Umbraco.Headless.Client.Net.Web;

namespace TeePhrase.Controllers
{
    public class BlogIndexController : BaseContentItemController
    {
        public BlogIndexController(UmbracoContext umbracoContext, PublishedContentService publishedContentService) : base(umbracoContext, publishedContentService)
        {
        }

        public override Task<IActionResult> Index()
        {
            return RenderContentItem<BlogIndex>();
        }
    }
}
