﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Morgenmadsbuffeten.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Restaurant()
        {
            return View();
        }
    }
}
