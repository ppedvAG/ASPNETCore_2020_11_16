using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul006
{
    public class CookieSampleModel : PageModel
    {
        [BindProperty]
        public string EmailAddress { get; set; }

        public void OnGet()
        {
            ViewData["abc"] = "wird wahrscheinlich nicht auf einer anderen Seite angezeigt";

            var cookieOptions = new CookieOptions
            {

                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Append("MyCookie", "value1", cookieOptions);
        }

        public IActionResult OnPost()
        {
            try
            {
                var cookieValue = Request.Cookies["MyCookie"];
                var email = new MailAddress(EmailAddress);
               
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
