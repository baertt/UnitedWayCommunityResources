using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace _340_Framework.Pages
{
    public class ContactModel : PageModel
    {
        private readonly AppDbContext _db;

        public ContactModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Organization Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}


