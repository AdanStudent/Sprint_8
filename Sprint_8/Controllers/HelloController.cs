using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sprint_8.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(string Name)
        {
            ViewData["Message"] = $"Hello {Name} from MVC";
            return View();
        }
        //public string Hello(string Name, int ?Age=0)
        //{
        //    return $"Hello {Name} from MVC and I'm {Age} years old"; 
        //}

        //public string Goodbye()
        //{
        //    return "Goodbye from MVC";
        //}
    }
}