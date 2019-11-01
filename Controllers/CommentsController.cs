using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Comments()
        {            
            return View();
        }
        

       
       
    }
}