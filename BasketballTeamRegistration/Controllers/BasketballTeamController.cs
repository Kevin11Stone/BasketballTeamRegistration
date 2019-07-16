using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasketballTeamRegistration.Controllers
{
    public class BasketballTeamController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}