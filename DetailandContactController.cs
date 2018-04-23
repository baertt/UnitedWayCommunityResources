using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityResources.Data;
using CommunityResources.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommunityResources.Controllers
{
    public class DetailandContactController : Controller
    {

        private readonly CommunityResourcesContext _context;

        public DetailandContactController(CommunityResourcesContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index()
        {
            var contact = from s in _context.Contacts.Include(c => c.Organization).OrderBy(s => s.OrganizationId)
                               select s;
            return View(await contact.AsNoTracking().ToListAsync());
        }


        // GET: Organizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            // RADER: I think here I may only need the Organization object
            var contact = await _context.Contacts
                .Include(org => org.Street_Address)
                .Include(org => org.Phone)
                .Include(org => org.Email)
                .Include(org => org.Website)
                .Include(org => org.Id)
                .Include(org => org.Organization) // this one
                .Include(org => org.OrganizationId) // and probably this too
                .Include(org => org.City)
                .Include(org => org.Zip)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Organizations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            // RADER:
            // I think here I do NOT need ID, org ID, or Org org
            // because those aren't values input by the user, but rather are
            // connected behind the scenes by us!
            [Bind("Street_Address,City,Zip,Phone,Email,Website")] Contact contact)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _context.Add(contact);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }

            return View(contact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // RADER: I think here I may only need the Organization object
            var contact = await _context.Contacts
               .Include(org => org.Street_Address)
                .Include(org => org.Phone)
                .Include(org => org.Email)
                .Include(org => org.Website)
                .Include(org => org.Id)
                .Include(org => org.Organization) // this one
                .Include(org => org.OrganizationId) // and probably this too
                .Include(org => org.City)
                .Include(org => org.Zip)
               .AsNoTracking()
               .SingleOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // RADER: I do not know what the parameters being passed here are for currently v v v v
            // but I think it's good to go now :P
            var contactToUpdate = await _context.Contacts.SingleOrDefaultAsync(contact => contact.OrganizationId == id);
            if (await TryUpdateModelAsync<Contact>(
                contactToUpdate,
                "",
                contact => contact.Phone, contact => contact.Email, contact => contact.Website,
                contact => contact.City, contact => contact.Id, contact => contact.Zip, 
                contact => contact.OrganizationId, contact => contact.Organization))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(contactToUpdate);
        }

        private Task<bool> TryUpdateModelAsync<T>(T contactToUpdate, string v, Func<T, object> p1, Func<T, object> p2, Func<T, object> p3, Func<T, object> p4, Func<T, object> p5, Func<T, object> p6, Func<T, object> p7)
        {
            throw new NotImplementedException();
        }

        // GET: Contact/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {

            if (id == null)
            {
                return NotFound();
            }


            // RADER: here I'm not entirely sure if m.Id should remain Id or OrgId or Org
            // Will follow up in class on Friday.
            var contact = await _context.Contacts
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }


            return View(contact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // RADER: here I'm not entirely sure if m.Id should remain Id or OrgId or Org
            // Will follow up in class on Friday.
            var contact = await _context.Contacts
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {

                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}


