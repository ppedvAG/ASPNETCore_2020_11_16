using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul001
{
    public class Calc3Model : PageModel
    {
       
        public int Ergebnis { get; set; }
        public int Eins { get; set; }
        public int Zwei { get; set; }


        public void OnGet()
        {
        }

        public void OnPostPlus()
        {
             Eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            Zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = Eins + Zwei;
        }

        public void OnPostMinus()
        {
            Eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            Zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = Eins - Zwei;
        }
    }
}
