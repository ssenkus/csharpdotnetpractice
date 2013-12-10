using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using partyTime.Models;

namespace partyTime.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            ViewBag.TimeNow = DateTime.Now;
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() 
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) 
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else {
                return View();  
            
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}