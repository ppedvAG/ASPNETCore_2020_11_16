using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodDependencyLib.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul004
{
    public class PartialViewSample3Model : PageModel
    {
        private ICarService _carService;
        public PartialViewSample3Model(ICarService carService)
        {
            _carService = carService;
        }

        public IList<Car> Cars { get; set; }


        public void OnGet()
        {
        }


        public PartialViewResult OnGetCarPartial()
        {
            Cars = _carService.GetAll();
            return Partial("_CarPartial", Cars);
        }
    }
}
