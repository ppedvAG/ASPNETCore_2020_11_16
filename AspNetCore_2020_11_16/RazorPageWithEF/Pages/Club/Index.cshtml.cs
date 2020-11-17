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
    public class IndexModel : PageModel
    {
        private readonly RazorPageWithEF.Data.RazorPageWithEFContext _context;

        public IndexModel(RazorPageWithEF.Data.RazorPageWithEFContext context)
        {
            _context = context;
        }

        public IList<FootballClub> FootballClub { get;set; }

        public async Task OnGetAsync()
        {
            FootballClub = await _context.FootballClub.ToListAsync();
        }
    }
}
