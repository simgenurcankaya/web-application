using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class Simge : Controller
    {
        // GET: /Simge/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([FromBody] SampleData person)
        {
            int Id = person.ID;
            string name = person.Name;
            string gender = person.Gender;

            return View();
        }
        public IActionResult hhh()
        {
            return View();
        }
    }
}
