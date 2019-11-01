using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Linq;
using System.Web;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Stories()
        {
            return View("Stories");
        }

        //Overloaded Stories 
        [HttpPost]
        public ViewResult Stories(UserStory userstories)
        {
            Repository.AddResponse(userstories);
            Repository.SortStories();
            return View("Submitted", userstories);
        }

        public ViewResult History()
        {
            return View("History");
        }

        public ViewResult Sources()
        {
            return View("Sources");
        }

        public ViewResult ListStories()
        {
            return View(Repository.stories);
        }

        public ViewResult BooksAndPrint()
        {
            Repository.SortBooksAndPrintList();
            return View(Repository.printMedia);
        }

        public ViewResult AddComment()
        {
            ViewBag.Test = "Testing View Bag for excercise";
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddComment(string name, string comment)
        {      
            ViewBag.Test = "Testing View Bag for excercise";

          
            Repository.AddComment(new UserComments()
            {
                Name = name,
                Comment = comment
            });

            Repository.AddCommentToStory(comment);           
          
            return RedirectToAction("Stories");
        }

      

        

        public ViewResult OnlineResources()
        {
            return View(Repository.onlineResources);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
