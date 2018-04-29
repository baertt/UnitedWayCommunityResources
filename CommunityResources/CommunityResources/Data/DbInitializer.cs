using CommunityResources.Models;
using System;
using System.Linq;

namespace CommunityResources.Data
{
    public class DbInitializer
    {
        public static void Initialize(CommunityResourcesContext context)
        {
            context.Database.EnsureCreated();


            //Look for any students.
            if (!context.Organizations.Any())
            {

                var organizations = new Organization[]
                {
                new Organization{Name="Single Parent Scholarship Fund of Faulkner County", Photo_ID=0, Other_Requirements=0,
                    Other_Requirements_Text ="Recipients must be a single parent and enrolled in a college, university or trade school to receive a scholarship.",
                        Appointments_Available =1, Appointments_Required=0, Additional_Comments=""},
                
                //new Organization{Name="", Photo_ID=, Other_Requirements=, Other_Requirements_Text="", Appointments_available=,
                //Appointments_Required=, Additional_Comments=""} 
                };
                foreach (Organization org in organizations)
                {
                    context.Organizations.Add(org);
                }
                context.SaveChanges();

                var contacts = new Contact[]
                {
                new Contact{OrganizationId=1, Street_Address="PO Box 1212", City="Conway", Zip="72033",
                    Email ="dscott@aspsf.org", Phone="15014204638",Website="www.aspsf.org"},
                
                // new Contact{OrganizationId=, Street_Address="", City="", Zip=, Email="", Phone="",Website=""}
                };
                foreach (Contact c in contacts)
                {
                    context.Contacts.Add(c);
                }
                context.SaveChanges();

                var resources = new Resource[]
                {
                new Resource{OrganizationId=1,Clothing=0,Education=1,Employment=0,Finances=0,Food=0,
                    Natural_Disaster =0,Senior=0, Rent_Utilities=0,Medical_Prescription=0,
                    Veterans =0,Housing=0,Other_Resources=0,Other_Resources_Text=""},
                
                //new Resource{OrganizationId=,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                    //Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                    //Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text=""},
    };
                foreach (Resource r in resources)
                {
                    context.Resources.Add(r);
                }
                context.SaveChanges();

                var times = new Time[]
                {
                    new Time{OrganizationId=1, Day="Monday", Repeat=0,Time_Start="8:00", Time_End="16:30"},
                    new Time{OrganizationId=1, Day="Tuesday", Repeat=0,Time_Start="8:00", Time_End="16:30"},
                    new Time{OrganizationId=1, Day="Wednesday", Repeat=0,Time_Start="8:00", Time_End="16:30"},
                    new Time{OrganizationId=1, Day="Thursday", Repeat=0,Time_Start="8:00", Time_End="16:30"},
                    new Time{OrganizationId=1, Day="Friday", Repeat=0,Time_Start="8:00", Time_End="16:30"},
                   
                
                //new Time{OrganizationId=, Day=DayOfWeek, Repeat=,Time_Start=TimeSpan.Parse(), Time_End=TimeSpan.Parse()},
                };
                foreach (Time t in times)
                {
                    context.Times.Add(t);
                }
                context.SaveChanges();
            }
        }
    }
}
