using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetVideoCore.Models;

namespace AspNetVideoCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Video>
            {
                new Video{ Id=1, Title="3:10 to Yuma"},
                new Video{ Id=2, Title="Transporter"},
                new Video{ Id=3, Title="Death Race"}
            };
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
