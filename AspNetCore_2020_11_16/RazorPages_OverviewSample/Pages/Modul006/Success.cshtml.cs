using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul006
{
    public class SuccessModel : PageModel
    {
        public void OnGet()
        {

            //TempData["abc"] = "defg";

            //Beispiel1:
            var temp = TempData.Peek("FormResult");


            //Beispiel2:
            var result = TempData["FormResult"];
            TempData.Keep();

            //Beispiel3: 
            var result1 = TempData["FormResult"];
            TempData.Keep("FormResult");
        }
    }
}
