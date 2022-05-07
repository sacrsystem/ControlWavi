using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControlWavi.Models;
using ControlWavi.Data;

namespace ControlWavi.Controllers
{
    public class CatalogoController: Controller
    {
       private readonly ILogger<CatalogoController> _logger;
        private readonly ApplicationDbContext _context;

        public CatalogoController(ApplicationDbContext context,
            ILogger<CatalogoController> logger)
        {
            _context = context;
            _logger = logger;
        } 

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]

    }
    }
