using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeePhrase.Models;
using Umbraco.Headless.Client.Net.Services; 

namespace TeePhrase.Controllers
{
    public class HomeController : Controller
    {
        private readonly PublishedContentService _publishedContentService;

        public HomeController(PublishedContentService publishedContentService)
        {
            _publishedContentService = publishedContentService;
        }
        
        public async Task<IActionResult> Headless()
        {
            // Get content by ContentType
            var content = await _publishedContentService.GetAll("design");
            return View(content);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
