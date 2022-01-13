using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Iactionresult ile actionresult aynı resultları döndürebilir fakaatt IActionResuş interface olarak işaretlenmiştri.Net core da 
        public IActionResult About()
        {
            return View();
        }
    }
}
