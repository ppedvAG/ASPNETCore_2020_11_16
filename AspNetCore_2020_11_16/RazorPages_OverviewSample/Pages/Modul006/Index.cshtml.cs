using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul006
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string FormResult { get; set; }


        [ViewData]
        public string FromBlub { get; set; }

        [BindProperty]
        public string EmailAddress { get; set; }

        public void OnGet()
        {
            ViewData["abc"] = "wird wahrscheinlich nicht auf einer anderen Seite angezeigt";
        }

        public IActionResult OnPost()
        {
            try
            {
                var email = new MailAddress(EmailAddress);
                FormResult = "You have provided a valid email address";
                TempData["def"] = "You have provided a valid email address";

                FromBlub = "wird wahrscheinlich nicht auf einer anderen Seite angezeigt";
                return RedirectToPage("success");
            }
            catch (FormatException)
            {
                ModelState.AddModelError("EmailAddress", "Invalid email address");
                return Page();
            }
        }
    }
}
