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
    public class SessionStartModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetString("keyabc", "Hi Felix");
            HttpContext.Session.SetInt32("keydef", 25);


            ICar car = new Car()
            {
                Brandt = "VW",
                Model = "Käfer",
                ConstructionYear = DateTime.Now,
                Color = "Blau"
            };

            string jsonString = JsonSerializer.Serialize(car);

            HttpContext.Session.SetString("MyObj", jsonString);
        }


        
    }
}
