using AudiWeb.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudiWeb.Controllers
{
    public class AutosController : Controller
    {
        public IActionResult Index()
        {
            var autos = AutoStorage.Autos;
            return View(autos);
        }
    }
}
