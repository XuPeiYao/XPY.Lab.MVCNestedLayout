using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace XPY.Lab.MVCNestedLayout.Controllers
{
    public class FunAController : Controller
    {
        private readonly ILogger<FunAController> _logger;

        public FunAController(ILogger<FunAController> logger)
        {
            _logger = logger;
        }
        public IActionResult Action1()
        {
            return View();
        }
        public IActionResult Action2()
        {
            return View();
        }
        public IActionResult Action3()
        {
            return View();
        }
    }
}
