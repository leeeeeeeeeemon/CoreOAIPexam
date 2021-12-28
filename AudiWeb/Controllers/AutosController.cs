using AudiWeb.Core;
using CoreOAIPexam;
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

        [HttpPost]
        public IActionResult Add(Auto avto)
        {
            AutoStorage.Add(avto);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove(string name)
        {
            AutoStorage.RemoveByName(name);
            return RedirectToAction("Index");
        }

        public void Buy()
        {
            //TempData["alertMessage"] = "Whatever you want to alert the user with";

        }
    }
}
