using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swipe.Web.Clients;
using Swipe.Web.Models;

namespace Swipe.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostGraphClient postGraphClient;

        public HomeController(ILogger<HomeController> logger, PostGraphClient postGraphClient)
        {
            _logger = logger;
            this.postGraphClient = postGraphClient;
        }

        public async Task<IActionResult> Index()
        {
            var post = await postGraphClient.GetRandomPost();
            //var post = await postGraphClient.GetPost(1);
            return View(post);
        }
        public async Task<IActionResult> Next()
        {
            //var post = await postGraphClient.GetRandomPost();
            var post = await postGraphClient.GetRandomPost();
            return View(post);
        }
        public IActionResult Privacy()
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
