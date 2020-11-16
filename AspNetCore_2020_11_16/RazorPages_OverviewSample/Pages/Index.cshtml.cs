using GoodDependencyLib.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_OverviewSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICar _car;

        public IndexModel(ILogger<IndexModel> logger, ICar carObj)
        {
            _logger = logger;
            _car = carObj;
        }

        public void OnGet()
        {
            _logger.LogInformation("Call IndexModel"); //Da wir Serilog in der Programm.cs MAin-Methode für den IOC Container verfügbar gemacht haben, ist es möglich diesen hier zu verwenden. 
        }
    }
}
