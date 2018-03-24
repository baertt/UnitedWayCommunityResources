using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _340_Framework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _340_Framework.Controllers
{
    public class _340_FrameworkController : Controller
    {

        private readonly AppDbContext _context;

        public _340_FrameworkController(AppDbContext context)
        {
            _context = context;
        }
        // GET: _340_Framework
        public async Task<IActionResult> Index()
        {
            return View(await _context.Organization.ToListAsync());
        }

        // GET: _340_Framework/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: _340_Framework/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: _340_Framework/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: _340_Framework/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: _340_Framework/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: _340_Framework/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: _340_Framework/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}