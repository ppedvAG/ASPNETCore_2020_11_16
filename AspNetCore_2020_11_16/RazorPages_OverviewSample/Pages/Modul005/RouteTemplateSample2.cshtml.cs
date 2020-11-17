using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul005
{
    public class RouteTemplateSample2Model : PageModel
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public void OnGet(int year, int month, int day, string title)
        {

            Title = title;
        }
    }
}
