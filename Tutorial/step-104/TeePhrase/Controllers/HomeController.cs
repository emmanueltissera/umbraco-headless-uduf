using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeePhrase.Models;
using Umbraco.Headless.Client.Net.Services;
using Umbraco.Headless.Client.Net.Web;

namespace TeePhrase.Controllers
{
    public class HomeController : DefaultUmbracoController
    {
        public HomeController(UmbracoContext umbracoContext, PublishedContentService headlessService) : base(
            umbracoContext, headlessService)
        {
        }

        public override Task<IActionResult> Index()
        {

            // get the content for the current route
            var content = UmbracoContext.GetContent(false);

            // map the ContentItem to a custom model called Home
            var model = HeadlessService.MapTo<Home>(content);

            // return the view which will be located at
            return Task.FromResult((IActionResult)View(model));
        }
    }

}
