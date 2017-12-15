using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using octolifecycle.Models;

namespace octolifecycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly Settings _settings;

        public HomeController(Settings settings)
        {
            _settings = settings;
        }

        public IActionResult Index()
        {
            ViewData["Environment"] = _settings.Environment;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Environment"] = _settings.Environment;
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Environment"] = _settings.Environment;
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
