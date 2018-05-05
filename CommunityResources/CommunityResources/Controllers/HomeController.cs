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




        [HttpPost]
        public ActionResult AdvancedResults(string day, string searchString)
        {

            var countries = new SelectList(
                 from c in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>()
                .Select(dow => new { Value = (int)dow, Text = dow.ToString() })
                .ToList() select c);
               //from c in _context.Times.Select(d => d.Day).Distinct().ToList() select c);
            ViewBag.day = countries;

            List<Organization> orgs = (from s in _context.Organizations.Include(c => c.Times).OrderBy(s => s.Name)
                               select s).ToList();

            var times = from t in _context.Organizations.SelectMany(v => v.Times) select t;
            if (day != null) { 
            orgs = (from u in orgs
                    join ti in _context.Times
                    on u.Id equals ti.OrganizationId
                    where ti.Day == day select u).ToList();
        }

            return View(orgs);
        }

       

        public ActionResult InitialResults(int?id, string day, int? repeats, string timeS, string timeE, string datepicker)
        {
            List<Organization> organization = (from s in _context.Organizations
                                               .Include(c => c.Times)
                                               .Include(c => c.Contacts)
                                               .OrderBy(s => s.Name)
                                               select s).ToList();

            var weekdays = new SelectList(
               from c in _context.Times.Select(d => d.Day).Distinct().ToList() select c);
            ViewBag.day = weekdays;

            ViewData["result"] = id;

            var reps = new SelectList(
               from c in _context.Times.Select(d => d.Repeat).Distinct().ToList() select c);
            ViewBag.repeats = reps;
            ViewData["displayName"] = "Resources";

            System.Diagnostics.Debug.WriteLine("Trying to get clothing info");
            if (id == 1) {
                ViewData["displayName"] = "Clothing";
               organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Clothing == 1
                                select s).ToList();
            }
            else if (id == 2)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Education == 1
                                select s).ToList();
            }
            else if (id == 3)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Employment == 1
                                select s).ToList();
            }
            else if (id == 4)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Finances== 1
                                select s).ToList();
            }
            else if (id == 5)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Food == 1
                                select s).ToList();
            }
            else if (id == 6)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Housing == 1
                                select s).ToList();
            }
            else if (id == 7)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Natural_Disaster == 1
                                select s).ToList();
            }
            else if (id == 8)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Senior == 1
                                select s).ToList();
            }
            else if (id == 9)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Rent_Utilities == 1
                                select s).ToList();
            }
            else if (id == 10)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Medical_Prescription == 1
                                select s).ToList();
            }
            else if (id == 11)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Veterans == 1
                                select s).ToList();
            }
            else if (id == 12)
            {
                organization = (from s in organization
                                join ti in _context.Resources
                                on s.Id equals ti.OrganizationId
                                where ti.Other_Resources == 1
                                select s).ToList();
            }

            if (day != null)
            {
                organization = (from s in organization
                                join ti in _context.Times
                        on s.Id equals ti.OrganizationId
                        where ti.Day == day
                        select s).ToList();
            }
            if (repeats != null)
            {
                organization = (from s in organization
                                join ti in _context.Times
                                on s.Id equals ti.OrganizationId
                                where (ti.Repeat == repeats) || (ti.Repeat == 0)
                                select s).Distinct().ToList();
            }
            if (timeS != null && timeE != null)
            { 
                
                organization = (from s in organization
                                join ti in _context.Times
                                on s.Id equals ti.OrganizationId
                                where (Int32.Parse(ti.Time_End )> Int32.Parse(timeS)  )
                                && (Int32.Parse(ti.Time_Start) < Int32.Parse(timeE))
                                select s).Distinct().ToList();
            }
            return View(organization);
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
