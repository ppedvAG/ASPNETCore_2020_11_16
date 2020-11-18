using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageWithEF.Data;
using RazorPageWithEF.Models;

namespace RazorPageWithEF.Pages.Club
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageWithEF.Data.RazorPageWithEFContext _context;

        public CreateModel(RazorPageWithEF.Data.RazorPageWithEFContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FootballClub FootballClub { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            //Ohne eine [BindProperty] kann man die Formularwerte auch aus dem Request.Form["name"]
            //string clubName = Request.Form["FootballClub.ClubName"];


            if (FootballClub.ClubName.StartsWith("FC"))
                ModelState.AddModelError("ClubInfo", "Alle Vereine die mit einem FC anfangen, steigen eh bald ab!");

            if (!ModelState.IsValid)
            {
                //Wenn der FootballClub falsch ausgefüllt wurde, dann wird man zu Create-Seite zurück verwiesen
                return Page();
            }

            _context.FootballClub.Add(FootballClub);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
