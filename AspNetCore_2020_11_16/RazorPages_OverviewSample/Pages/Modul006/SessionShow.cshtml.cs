using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using GoodDependencyLib.Service;
using System.Text.Json;

namespace RazorPages_OverviewSample.Pages.Modul006
{
    public class SessionShowModel : PageModel
    {
        public void OnGet()
        {
            string Name = HttpContext.Session.GetString("keyabc");
            
            int? Age = HttpContext.Session.GetInt32("keydef");

            if (Age.HasValue)
            {
                //Mach was mit der Variable Age (kleine Exkursus in nullable datatype
            }

            string jsonString = HttpContext.Session.GetString("MyObj");
            ICar movie = JsonSerializer.Deserialize<Car>(jsonString);
        }
    }
}
