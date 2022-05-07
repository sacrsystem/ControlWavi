using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControlWavi.Models;

namespace ControlWavi.Controllers
{
    public class Catalogo : Controller
    {
        private readonly ILogger<Catalogo> _logger;

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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
