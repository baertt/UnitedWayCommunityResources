using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _340_Framework.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _340_Framework.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
        private readonly AppDbContext _db;

        public AboutModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Models.Organization Orgs { get; set; }
        public Models.Resources Resources { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Organizations.Add(Orgs);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}

