using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityResources.Models;
using CommunityResources.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunityResources.Controllers
{

    public class HomeController : Controller
    {
        private readonly CommunityResourcesContext _context;
        

        public HomeController(CommunityResourcesContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            System.Diagnostics.Debug.WriteLine("Just the Front");
            return View();
        }





        public ActionResult AdvancedResults(string day, string searchString)
        {
            var countries = new SelectList(
               from c in _context.Times.Select(d => d.Day).Distinct().ToList() select c);
            ViewBag.day = countries;

            List<Organization> orgs = (from s in _context.Organizations.Include(c => c.Times).OrderBy(s => s.Name)
                               select s).ToList();

            var times = from t in _context.Organizations.SelectMany(v => v.Times) select t;
            if (day != null) { 
            orgs = (from u in _context.Organizations
                                       join ti in _context.Times
                                       on u.Id equals ti.OrganizationId
                                       where ti.Day == day select u).ToList();
        }

            return View(orgs);
        }

       

        public async Task<IActionResult> InitialResults(int?id)
        {
            var organization = from s in _context.Organizations.Include(c => c.Contacts).OrderBy(s => s.Name)
                               select s;

            System.Diagnostics.Debug.WriteLine("Trying to get clothing info");
            if (id == 1) {
                System.Diagnostics.Debug.WriteLine("Clothssssssssssssssssssssssss");
                organization = organization.Where(s => s.Resources.Clothing.Equals(1));
                System.Diagnostics.Debug.WriteLine(organization.Count());
            }
            else if (id == 2)
            {
                organization = organization.Where(s => s.Resources.Education.Equals(1));
            }
            else if (id == 3)
            {
                organization = organization.Where(s => s.Resources.Employment.Equals(1));
            }
            else if (id == 4)
            {
                organization = organization.Where(s => s.Resources.Finances.Equals(1));
            }
            else if (id == 5)
            {
                organization = organization.Where(s => s.Resources.Food.Equals(1));
            }
            else if (id == 6)
            {
                organization = organization.Where(s => s.Resources.Housing.Equals(1));
            }
            else if (id == 7)
            {
                organization = organization.Where(s => s.Resources.Natural_Disaster.Equals(1));
            }
            else if (id == 8)
            {
                organization = organization.Where(s => s.Resources.Senior.Equals(1));
            }
            else if (id == 9)
            {
                organization = organization.Where(s => s.Resources.Rent_Utilities.Equals(1));
            }
            else if (id == 10)
            {
                organization = organization.Where(s => s.Resources.Medical_Prescription.Equals(1));
            }
            else if (id == 11)
            {
                organization = organization.Where(s => s.Resources.Veterans.Equals(1));
            }
            else if (id == 12)
            {
                organization = organization.Where(s => s.Resources.Other_Resources.Equals(1));
            }
            
            return View(await organization.AsNoTracking().ToListAsync());
            //return View(await _context.Organizations.ToListAsync());
        }



        public IActionResult Results()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult GracesResults2()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
