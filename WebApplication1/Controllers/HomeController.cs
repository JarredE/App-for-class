using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() //ActionResult
        {
            
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View("RsvpForm");
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        public ViewResult ListResponses() {
            return View(Repository.Responses);
        }

          
        }
}
