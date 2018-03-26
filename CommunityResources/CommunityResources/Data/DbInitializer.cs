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

            // Look for any students.
            if (context.Organizations.Any())
            {
                return;   // DB has been seeded
            }

            var organizations = new Organization[]
            {
            new Organization{Name="Single Parent Scholarship Fund of Faulkner County", Photo_ID=false, Other_Requirements=false,
                Other_Requirements_Text ="Recipients must be a single parent and enrolled in a college, university or trade school to receive a scholarship.",
                Appointments_Availible =true, Appointments_Required=false, Additional_Comments=""},
            new Organization{Name="CHDC Volunteer Services", Photo_ID=true, Other_Requirements=false, Other_Requirements_Text="",
                Appointments_Availible =true, Appointments_Required=true, Additional_Comments=""},
            new Organization{Name="Faulkner County Long Term Recovery Board", Photo_ID=false, Other_Requirements=false,
                Other_Requirements_Text ="", Appointments_Availible=false, Appointments_Required=false, Additional_Comments=""},
            new Organization{Name="The Storehouse Client Choice Pantry", Photo_ID=false, Other_Requirements=false, Other_Requirements_Text="",
                Appointments_Availible =false, Appointments_Required=false, Additional_Comments=""}
            //new Organization{Name="", Photo_ID=, Other_Requirements=, Other_Requirements_Text="", Appointments_Availible=,
            //Appointments_Required=, Additional_Comments=""} 
            };
            foreach (Organization org in organizations)
            {
                context.Organizations.Add(org);
            }
            context.SaveChanges();

            var contacts = new Contact[]
            {
            new Contact{OrganizationId=1, Street_Address="PO Box 1212", City="Conway", Zip=72033,
                Email ="dscott@aspsf.org", Phone="15014204638",Website="www.aspsf.org"},
            new Contact{OrganizationId=2, Street_Address="150 E. Siebenmorgen rd", City="Conway", Zip=72032,
                Email ="elizabeth.molica@dhs.arkansas.gov", Phone="5013296851",Website="www.chdconline.wixsite.com/conwayhdc"},
            new Contact{OrganizationId=3, Street_Address="P.O. Box 1614", City="Conway", Zip=72034,
                Email ="pamela.mcbroome@gmail.com", Phone="5015141695",Website=""},
            new Contact{OrganizationId=4, Street_Address="766 Harkrider St", City="Conway", Zip=73032,
                Email ="laura@ministrycenter.org", Phone="5013586098",Website="www.conwayministrycenter.org"}
            // new Contact{OrganizationId=, Street_Address="", City="", Zip=, Email="", Phone="",Website=""}
            };
            foreach (Contact c in contacts)
            {
                context.Contacts.Add(c);
            }
            context.SaveChanges();

            var resources = new Resource[]
            {
            new Resource{OrganizationId=1,Clothing=false,Education=true,Employment=false,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=2,Clothing=false,Education=false,Employment=true,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=3,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                Natural_Disaster =true,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=4,Clothing=false,Education=false,Employment=false,Finances=false,Food=true,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Other_Resources=false,Other_Resources_Text="Hygiene Items"},
            //new Resource{OrganizationId=,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                //Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                //Veterans =false,Other_Resources=false,Other_Resources_Text=""},
};
            foreach (Resource r in resources)
            {
                context.Resources.Add(r);
            }
            context.SaveChanges();

            var times = new Time[]
            {
            new Time{OrganizationId=1, Day=DayOfWeek.Monday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Tuesday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Wednesday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Thursday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Friday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=4, Day=DayOfWeek.Thursday, Repeat=0,Time_Start=TimeSpan.Parse("9:30"), Time_End=TimeSpan.Parse("13:30")}
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
