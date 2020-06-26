using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetVideoCore.Models;
using AspNetVideoCore.Services;
using AspNetVideoCore.ViewModels;

namespace AspNetVideoCore.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData videos;
        public HomeController(IVideoData videos)
        {
            this.videos = videos;
        }
        public IActionResult Index()
        {
            var model = videos.GetAll().Select(video=> new VideoViewModel {Id=video.Id,Title=video.Title,Genre=Enum.GetName(typeof(Genres),video.GenreId) });

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
