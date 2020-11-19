using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Morgenmadsbuffeten.Controllers
{
    public class ReceptionController : Controller
    {
        public IActionResult Reception()
        {
            return View();
        }
    }
    
}
