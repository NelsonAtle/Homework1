using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class SoftwareModel : PageModel
    {
        

        public void OnGet()
        {
            ViewData["Title"] = "Software Development";
            ViewData["Web"] = "Your company may take advantage on others through a web app adjusted to its needs. In this solution you’ll find: speed, reasonable prices and quality.";
            ViewData["App"] = "Instantly and from anywhere, users can access information on their mobile devices. In a world where speed and easiness is everything, your company must be accessible from a mobile device.";

        }
    }
}
