using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sync162046.Areas.Controllers
{
    [Area("Aug102018")]
    public class DatepickerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}