using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmoothMultilevelAccordion.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http.Extensions;

namespace SmoothMultilevelAccordion.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string module, string route, string child)
        {

            _logger.LogInformation($"Area:{module},Controller:{route},Action:{child}");

            ViewBag.Info =Request.GetDisplayUrl();

            return View();
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
