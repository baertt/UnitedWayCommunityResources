using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityResources.Models;
using CommunityResources.Data;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult AdvancedResults()
        {
            var organization = from s in _context.Organizations
                               select s;
            return View(organization);

        }

        [HttpPost]
        public  ActionResult AdvancedResults(int? id)
        {

            string dayOfWeek = Request.Form["DayOfWeek"].ToString();
            var organization = from s in _context.Organizations
                               .Include(c => c.Contacts)
                               .Include(c => c.Times)
                               .OrderBy(c => c.Name)
                               select s;
            foreach (Organization s in organization)
            {
                _context.Entry(s).Collection(t => t.Times).Load();
                foreach (Time i in s.Times) { 
                    if (i.Day.Equals("M") && dayOfWeek == "1")
                    {

                    }
                    if (i.Day.Equals("T") && dayOfWeek == "2")
                    {

                    }
                    if (i.Day.Equals("W") && dayOfWeek =="3")
                    {

                    }
                    if (i.Day.Equals("R") && dayOfWeek == "4")
                    {

                    }
                    if (i.Day.Equals("F") && dayOfWeek == "5")
                    {

                    }
                    if (i.Day.Equals("Sa") && dayOfWeek == "6")
                    {

                    }
                    if (i.Day.Equals("Su") && dayOfWeek == "7")
                    {

                    }
                    //if (dayOfWeek == "Monday")
                    //{
                    //    organization = organization.Where(s);
                    //}
                    //else if (dayOfWeek == "Tuesday")
                    //{
                    //    organization = organization.Where(s => s.TimesNotList.Day.Equals("T"));
                    //}
                    //else if (dayOfWeek == "Wednesday")
                    //{
                    //    organization = organization.Where(s => s.TimesNotList.Day.Equals("W"));
                    //}
                    //else if (dayOfWeek == "Thursday")
                    //{
                    //    organization = organization.Where(s => s.TimesNotList.Day.Equals("R"));
                    //}
                    //else if (dayOfWeek == "Friday")
                    //{
                    //    organization = organization.Where(s => s.TimesNotList.Day.Equals("F"));
                    //}
                    //else if (dayOfWeek == "Saturday")
                    //{
                    //    organization = organization.Where(s => s.TimesNotList.Day.Equals("Sa"));
                    //}
                    //else if (dayOfWeek == "Sunday")
                    //{
                    //    organization = organization.Where(s => s.TimesNotList.Day.Equals("Su"));
                    //}
                }
            }
            return View(organization.AsNoTracking().ToListAsync());
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

        public IActionResult GracesResults()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
