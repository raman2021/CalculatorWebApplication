using CalculatorWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApplication.Controllers
{
    public class ControllerCalculator : Controller
    {
        public IActionResult Index()
        {
            return View(new Calc());
        }
      
    }
}
