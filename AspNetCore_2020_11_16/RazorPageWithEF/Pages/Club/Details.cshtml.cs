using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageWithEF.Data;
using RazorPageWithEF.Models;

namespace RazorPageWithEF.Pages.Club
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageWithEF.Data.RazorPageWithEFContext _context;

        public DetailsModel(RazorPageWithEF.Data.RazorPageWithEFContext context)
        {
            _context = context;
        }

        public FootballClub FootballClub { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FootballClub = await _context.FootballClub.FirstOrDefaultAsync(m => m.Id == id);

            if (FootballClub == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
