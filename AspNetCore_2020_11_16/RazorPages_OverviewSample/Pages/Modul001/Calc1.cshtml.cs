using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul001
{
    public class Calc1Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {
            Ergebnis = 0;
        }
    }
}
