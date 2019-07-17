using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasketballTeamRegistration.Controllers
{
    public class BasketballTeamController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Register(IFormCollection team)
        {
            string teamName = team["team-name"];
            return View();
        }
    }
}