﻿using System;
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
    public class TimesController : Controller
    {
        private readonly CommunityResourcesContext _context;

        public TimesController(CommunityResourcesContext context)
        {
            _context = context;
        }

        // GET: Times
        public async Task<IActionResult> Index()
        {
            var communityResourcesContext = _context.Times
                .Include(t => t.Organization);
            return View(await communityResourcesContext.ToListAsync());
        }

        public IActionResult AddTimes(int? id)
        {
            ViewData["FK"] = id;
            List<Time> orgs = (from i in _context.Times.Include(c => c.Organization)
                               select i).ToList();
            if (id != null) { 
            orgs = (from ti in _context.Times
                    join u in _context.Organizations
                    on  ti.OrganizationId equals u.Id
                    where ti.OrganizationId == id
                    select ti).ToList();
            }
            return View(orgs);
        }


        // GET: Times/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var time = await _context.Times
                .Include(t => t.Organization)
                .SingleOrDefaultAsync(m => m.TimesId == id);
            if (time == null)
            {
                return NotFound();
            }

            return View(time);
        }

        // GET: Times/Create
        public IActionResult Create(int? id)
        {
            ViewData["FK"] = id;
            ViewData["OrganizationId"] = new SelectList(_context.Organizations.Where(m => m.Id.Equals(id)), "Id", "Name");
            return View();
        }

        // POST: Times/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimesId,Time_Start,Time_End,Repeat,Day,OrganizationId")] Time time)
        {
            if (ModelState.IsValid)
            {
                _context.Add(time);

                await _context.SaveChangesAsync();
                return RedirectToAction("AddTimes", "Times", new { id = time.OrganizationId });
            }

            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "Id", "Name", time.OrganizationId);
            return View(time);
        }

        // GET: Times/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var time = await _context.Times.SingleOrDefaultAsync(m => m.TimesId == id);
            if (time == null)
            {
                return NotFound();
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "Id", "Name", time.OrganizationId);
            return View(time);
        }

        // POST: Times/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimesId,Time_Start,Time_End,Repeat,Day,OrganizationId")] Time time)
        {
            if (id != time.TimesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(time);
                    
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeExists(time.TimesId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("AddTimes", "Times", new { id = time.OrganizationId });
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "Id", "Name", time.OrganizationId);

            return RedirectToAction("AddTimes", "Times", new { id = time.OrganizationId });
        }

        // GET: Times/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var time = await _context.Times
                .Include(t => t.Organization)
                .SingleOrDefaultAsync(m => m.TimesId == id);
            
            if (time == null)
            {
                return NotFound();
            }

            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var time = await _context.Times.SingleOrDefaultAsync(m => m.TimesId == id);
            _context.Times.Remove(time);
            await _context.SaveChangesAsync();
            return RedirectToAction("AddTimes", "Times", new { id = time.OrganizationId });
        }

        private bool TimeExists(int id)
        {
            return _context.Times.Any(e => e.TimesId == id);
        }
    }
}
