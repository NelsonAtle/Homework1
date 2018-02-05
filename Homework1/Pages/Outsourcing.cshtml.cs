using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class OutsourcingModel : PageModel
    {

        public void OnGet()
        {
            ViewData["Title"] = "Outsourcing";
            ViewData["Info"] = "If you need greater team reach or a whole team project, Go-Labs has professionals at your disposal, such a project managers, engineers and QA specialists, who can supply the actual demand in a fast and secure way.";

        }
    }
}