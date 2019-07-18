using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketballTeamRegistration.Models;
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
            
            Team newTeam = new Team()
            {
                TeamName = team["team-name"],
                TeamCaptain = team["team-captain"],
                CoachName = team["coach-name"],
                Scheme = team["scheme"],
                Playmaker = team["playmaker"]
            };
                   
            // add to database here

            return View();

        }


        // model binding

        [HttpGet]
        public IActionResult RegModelBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegModelBinding(Team t)
        {

            return View();
        }


    }
}