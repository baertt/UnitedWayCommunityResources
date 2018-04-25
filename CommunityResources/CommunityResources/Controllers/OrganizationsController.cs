using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityResources.Data;
using CommunityResources.Models;

namespace CommunityResources.Controllers
{
    public class OrganizationsController : Controller
    {
        private readonly CommunityResourcesContext _context;

        public OrganizationsController(CommunityResourcesContext context)
        {
            _context = context;
        }

        // GET: Organizations
        public async Task<IActionResult> Index(string searchString)
        {
            var organization = from s in _context.Organizations.Include(c => c.Contacts).OrderBy(s => s.Name)
                               select s;
            if (searchString != null) {
                organization = organization.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
            }
            return View(await organization.AsNoTracking().ToListAsync());
        }


        // GET: Organizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations
                .Include(org => org.Contacts)
                .Include(org => org.Resources)
                .Include(org => org.Times)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);

            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // GET: Organizations/Create
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
            [Bind("Name,Photo_ID,Other_Requirements,Other_Requirements_Text,Appointments_Availible,Appointments_Required,Additional_Comments")] Organization organization)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _context.Add(organization);
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

            return View(organization);
        }

        // GET: Organizations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations
               .Include(org => org.Contacts)
               .Include(org => org.Resources)
               .Include(org => org.Times)
               .AsNoTracking()
               .SingleOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }
            return View(organization);
        }

        // POST: Organizations/Edit/5
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
            var organizationToUpdate = await _context.Organizations.SingleOrDefaultAsync(org => org.Id == id);
            if (await TryUpdateModelAsync<Organization>(
                organizationToUpdate,
                "",
                org => org.Name, org => org.Photo_ID, org => org.Other_Requirements,
                org => org.Other_Requirements_Text, org => org.Appointments_Available,
                org => org.Appointments_Required, org => org.Additional_Comments))
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
            return View(organizationToUpdate);
        }

        // GET: Organizations/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {

            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }


            return View(organization);
        }

        // POST: Organizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var organization = await _context.Organizations
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {

                _context.Organizations.Remove(organization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool OrganizationExists(int id)
        {
            return _context.Organizations.Any(e => e.Id == id);
        }
    }
}
