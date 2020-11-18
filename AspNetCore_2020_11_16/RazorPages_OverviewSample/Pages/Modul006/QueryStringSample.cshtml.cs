using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_OverviewSample.Pages.Modul006
{
    public class QueryStringSampleModel : PageModel
    {
        //localhost:12345/Modul006/QueryStringSample?lastname=Mustermann&age=31&firstname=Peter
        //Reiehenfolge der Parameter ist egal. Es wird auf den Key/Variablennamen gemappt
        public void OnGet(string firstname, string lastname, int age)
        {
        }
    }
}
