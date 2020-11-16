using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul001
{
    public class Calc2Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet() //Standard -> OnGet
        {
            Ergebnis = 0;
        }
        public void OnGetHannes() //Multiple OnGet Funktionen kann man mit einem Handler ansteuern.
        {
            Ergebnis = 42;
        }

        public void OnPost()//Standard -> OnPost -> Wird ausgelöst durch type="submit"
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = eins + zwei;
        }
    }
}
