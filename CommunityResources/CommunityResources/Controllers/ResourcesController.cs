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
    public class ResourcesController : Controller
    {
        private readonly CommunityResourcesContext _context;

        public ResourcesController(CommunityResourcesContext context)
        {
            _context = context;
        }

        // GET: Resources
        public async Task<IActionResult> Index()
        {
            var communityResourcesContext = _context.Resources.Include(r => r.Organization);
            return View(await communityResourcesContext.ToListAsync());
        }

        // GET: Resources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resource = await _context.Resources
                .Include(r => r.Organization)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (resource == null)
            {
                return NotFound();
            }

            return View(resource);
        }

        // GET: Resources/Create
        public IActionResult Create(int? id)
        {
            ViewData["OrganizationId"] = new SelectList(_context.Organizations.Where(m => m.Id.Equals(id)), "Id", "Name");
            return View();




        }

        // POST: Resources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Id,OrganizationId,Clothing,Education,Employment,Finances,Food,Housing,Natural_Disaster,Senior,Rent_Utilities,Medical_Prescription,Veterans,Other_Resources,Other_Resources_Text")] Resource resource)
        {
            if (id != resource.Id)
            {
                return NotFound();
            }
           

            if (ModelState.IsValid)
            {
                _context.Add(resource);

                _context.Organizations.Where(m => m.Id == id).FirstOrDefault().Last_Updated = DateTime.Now.ToString();
                await _context.SaveChangesAsync();
                return RedirectToAction("AddTimes", "Times", new { id = resource.OrganizationId });
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "Id", "Name", resource.OrganizationId);
            return View(resource);
        }



        // GET: Resources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resource = await _context.Resources.SingleOrDefaultAsync(m => m.Id == id);
            if (resource == null)
            {
                return NotFound();
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations.Where(m => m.Id.Equals(id)), "Id", "Name", resource.OrganizationId);
            return View(resource);
        }

        // POST: Resources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrganizationId,Clothing,Education,Employment,Finances,Food,Housing,Natural_Disaster,Senior,Rent_Utilities,Medical_Prescription,Veterans,Other_Resources,Other_Resources_Text")] Resource resource)
        {
            if (id != resource.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resource);
                    _context.Organizations.Where(m => m.Id == id).FirstOrDefault().Last_Updated = DateTime.Now.ToString();
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResourceExists(resource.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Organizations", new { id = resource.OrganizationId });
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "Id", "Name", resource.OrganizationId);
            return View(resource);
        }

        // GET: Resources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resource = await _context.Resources
                .Include(r => r.Organization)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (resource == null)
            {
                return NotFound();
            }

            return View(resource);
        }

        // POST: Resources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resource = await _context.Resources.SingleOrDefaultAsync(m => m.Id == id);
            _context.Resources.Remove(resource);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResourceExists(int id)
        {
            return _context.Resources.Any(e => e.Id == id);
        }
    }
}
