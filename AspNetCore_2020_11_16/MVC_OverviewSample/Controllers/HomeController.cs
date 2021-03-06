﻿using GoodDependencyLib.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_OverviewSample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_OverviewSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICar car)
        {
            _logger = logger;
        }

        public IActionResult Index() // Ist eine Get-Methode
        {
            return View();
        }

        public IActionResult Privacy() // Ist eine Get-Methode
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Ist eine Get-Methode
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
