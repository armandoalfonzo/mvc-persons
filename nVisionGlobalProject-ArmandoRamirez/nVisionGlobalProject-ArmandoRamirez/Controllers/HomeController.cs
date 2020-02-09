using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using nVisionGlobalProject_ArmandoRamirez.Models;

namespace nVisionGlobalProject_ArmandoRamirez.Controllers
{
    public class HomeController : Controller
    {
        private string JsonRoot = $@"{System.IO.Directory.GetCurrentDirectory()}\wwwroot\Json";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                List<PersonViewModel> people = new List<PersonViewModel>();

                if (System.IO.File.Exists(JsonRoot))
                {
                    people = JsonConvert.DeserializeObject<List<PersonViewModel>>(System.IO.File.ReadAllText(JsonRoot));
                }
                people.Add(model);
                System.IO.File.WriteAllText(JsonRoot, JsonConvert.SerializeObject(people));                
            }
            return View();
        }

        [HttpGet]
        public string GetJson()
        {
            if (System.IO.File.Exists(JsonRoot))
            {
                return System.IO.File.ReadAllText(JsonRoot);
            }
            return "";
        }
    }
}
