using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Powitanie =  hour < 17 ? "Dzien dobry" : "Dobry wieczór";

            return View("MyView");
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
