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

      



        public ActionResult AdvancedResults(string movieGenre, string searchString)
        {
            //var DayLst = new List<string>();


            //DayLst.Add("M");
            //DayLst.Add("T");
            //DayLst.Add("W");
            //DayLst.Add("R");
            //DayLst.Add("F");
            //DayLst.Add("Sa");
            //DayLst.Add("Su");
            //ViewBag.movieGenres = new SelectList(DayLst);

            var movies = from m in _context.Organizations
                         .Include(m => m.Contacts)
                         .OrderBy(m => m.Name)
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Name.Contains(searchString));
            }


            return View(movies);
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
