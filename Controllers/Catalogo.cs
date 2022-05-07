using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ControlWavi.Controllers
{
    [Route("[controller]")]
    public class Catalogo : Controller
    {
        
        public Catalogo(ILogger<Catalogo> logger)
        {
            _logger = logger;
        }

        public IActionResult Index_catalogo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}