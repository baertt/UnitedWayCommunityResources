using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _340_Framework.Models;

namespace _340_Framework.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Orgs
            if (context.Organization.Any())
            {
                return;   // DB has been seeded
            }

            var orgs = new Organization[]
            {
            new Organization{Name="Single Parent Scholarship Fund of Faulkner County", Street_Address="PO Box 1212",
            City="Conway", Zip=72033, Website="www.aspsf.org", Email="dscott@aspsf.org", Phone="15014204638",
            Other_Requirements=true, Other_Requirements_Text="Recipients must be a single parent and enrolled in a " +
            "college, university or trade school to receive a scholarship.",Photo_ID=false, Appointments_Availible = true,
            Appointments_Required=false},
            new Organization{Name="CHDC Volunteer Services", Street_Address="150 E. Siebenmorgen rd",
            City="Conway", Zip=72032, Website="http://chdconline.wixsite.com/conwayhdc",
            Email ="elizabeth.molica@dhs.arkansas.gov", Phone="5013296851",
            Other_Requirements=false,Photo_ID=true, Appointments_Required=true},
            new Organization{Name="Faulkner County Long Term Recovery Board", Street_Address="P.O. Box 1614",
            City="Conway", Zip=72034, Email ="pamela.mcbroome@gmail.com", Phone="5015141695",
            Other_Requirements=false,Photo_ID=false, Appointments_Required=true},
            new Organization{Name="The Storehouse Client Choice Pantry", Street_Address="766 Harkrider St",
            City="Conway", Zip=72032, Email ="laura@ministrycenter.org", Phone="5013586098",
            Website="www.conwayministrycenter.org",Other_Requirements=false,Photo_ID=false }
            };
            foreach (Organization s in orgs)
            {
                context.Organization.Add(s);
            }
            context.SaveChanges();

            var times = new Times[]
            {
                new Times{Day=DayOfWeek.Monday, Repeat=0, Time_Start=TimeSpan.Parse("8:00 AM"),
                    Time_End = TimeSpan.Parse("4:30 PM"), OrganizationId=1},
                new Times{Day=DayOfWeek.Tuesday, Repeat=0, Time_Start=TimeSpan.Parse("8:00 AM"),
                    Time_End = TimeSpan.Parse("4:30 PM"), OrganizationId=1},
                new Times{Day=DayOfWeek.Wednesday, Repeat=0, Time_Start=TimeSpan.Parse("8:00 AM"),
                    Time_End = TimeSpan.Parse("4:30 PM"), OrganizationId=1},
                new Times{Day=DayOfWeek.Thursday, Repeat=0, Time_Start=TimeSpan.Parse("8:00 AM"),
                    Time_End = TimeSpan.Parse("4:30 PM"), OrganizationId=1},
                new Times{Day=DayOfWeek.Friday, Repeat=0, Time_Start=TimeSpan.Parse("8:00 AM"),
                    Time_End = TimeSpan.Parse("4:30 PM"), OrganizationId=1},
                new Times{Day=DayOfWeek.Thursday, Repeat=0, Time_Start=TimeSpan.Parse("9:30 AM"),
                    Time_End=TimeSpan.Parse("1:30 PM"), OrganizationId=4}
            };

            foreach (Times t in times)
            {
                context.Times.Add(t);
            }
            context.SaveChanges();

            var resources = new Resources[]
            {
                new Resources{OrganizationId=1, Education=true},
                new Resources{OrganizationId=2, Employment=true},
                new Resources{OrganizationId=3, Natural_Disaster=true},
                new Resources{OrganizationId=4, Food=true, Other_Resources=true,
                Other_Resources_Text = "Hygiene items"}
            };

            foreach (Resources r in resources)
            {
                context.Resources.Add(r);
            }
            context.SaveChanges();
        }
    }
}
