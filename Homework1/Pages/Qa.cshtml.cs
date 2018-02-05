using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class ContactModel : PageModel
    {
        

        public void OnGet()
        {
            ViewData["Title"] = "QA - Quality Assurance";
            ViewData["Info"] = "We’ll like to help you since day one improving software quality, working along with you in every step, until we are sure of the road and correct when it's needed.";
            
        }
    }
}
