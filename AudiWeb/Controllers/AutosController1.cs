using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudiWeb.Controllers
{
    public class AutosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
