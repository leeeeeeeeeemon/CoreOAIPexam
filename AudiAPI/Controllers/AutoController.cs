using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AudiAPI.Models;
using static CoreOAIPexam.DBconnection;
using AudiAPI.Service;
using CoreOAIPexam;
using Microsoft.AspNetCore.Mvc;


namespace AudiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoController : ControllerBase
    {
        public AutoController()
        {

        }

        // GET all action
        [HttpGet]
        public ActionResult<List<AutoM>> GetAll() => ProjectService.GetAll();

        //Get id
        [HttpGet("{id}")]
        public ActionResult<AutoM> Get(int id)
        {
            var auto = ProjectService.Get(id);

            if (auto == null)
                return NotFound();

            return auto;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(Auto avto)
        {
            ProjectService.Add(avto);
            return CreatedAtAction(nameof(Create), new { id = avto.id_auto }, avto);
        }
    }

    
}
