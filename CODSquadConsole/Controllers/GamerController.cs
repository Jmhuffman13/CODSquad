﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CODSquadConsole.Controllers
{
    public class GamerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
