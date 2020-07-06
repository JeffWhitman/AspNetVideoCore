using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetVideoCore.Models;
using AspNetVideoCore.Services;
using AspNetVideoCore.ViewModels;
using AspNetVideoCore.Entities;

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
            var model = videos.GetAll().Select(video=> new VideoViewModel {Id=video.Id,Title=video.Title,Genre=video.Genre.ToString() });

            return View(model);
        }
        public IActionResult Details(int Id)
        {
            var model=videos.Get(Id);

            return View(new VideoViewModel { Id=model.Id,Title=model.Title,Genre=model.Genre.ToString()});
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VideoEditViewModel model )
        {
            var video = new Video
            {
                Title = model.Title,
                Genre = model.Genre
            };
            videos.Add(video);

            return RedirectToAction("Details",new { id=video.Id});
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var video = videos.Get(id);

            if (video == null) return RedirectToAction("Index");

            return View(video);
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
