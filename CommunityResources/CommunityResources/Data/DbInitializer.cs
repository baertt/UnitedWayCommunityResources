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
                Appointments_Availible =false, Appointments_Required=false, Additional_Comments="" },
            new Organization{Name="Hope and Compassion Ministries", Photo_ID=false, Other_Requirements=false, Other_Requirements_Text="",
                Appointments_Availible =true, Appointments_Required=false, Additional_Comments=""},
            new Organization{Name="United Way", Photo_ID=true, Other_Requirements=false, Other_Requirements_Text="", Appointments_Availible=true,
                Appointments_Required=true, Additional_Comments=""},
            new Organization{Name="Conway FUMC", Photo_ID=true, Other_Requirements=false, Other_Requirements_Text="", Appointments_Availible=false,
                Appointments_Required=false, Additional_Comments=""},
            new Organization{Name="The CALL", Photo_ID=false, Other_Requirements=false, Other_Requirements_Text="", Appointments_Availible=true,
                Appointments_Required=true, Additional_Comments="They can call anytime"},
            new Organization{Name="Faulkner County Juvenile Court", Photo_ID=false, Other_Requirements=true, Other_Requirements_Text="Court Order", Appointments_Availible=true,
                Appointments_Required=true, Additional_Comments=""},
            new Organization{Name="Haven", Photo_ID=false, Other_Requirements=false, Other_Requirements_Text="", Appointments_Availible=true,
                Appointments_Required=true, Additional_Comments=""}, 
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
                Email ="laura@ministrycenter.org", Phone="5013586098",Website="www.conwayministrycenter.org"},
            new Contact{OrganizationId=5, Street_Address="1105 Deer St suite 14", City="Conway", Zip=73034,
                Email ="ghogan@hopeandcompassion.org", Phone="5015141625",Website="www.hopeandcompassion.org"},
            new Contact{OrganizationId=6, Street_Address="201 Donaghey", City="Conway", Zip=72035, Email="vbirmingham1@cub.uca.edu", Phone="",Website=""},
            new Contact{OrganizationId=7, Street_Address="1610 Prince Street", City="Conway", Zip=72034,
                Email ="dadkisson@conwayfumc.org", Phone="5013293801",Website="Conwayfumc.org"},
            new Contact{OrganizationId=8, Street_Address="766 Harkrider Street", City="Conway", Zip=73032,
                Email ="conwayfaulkner@thecallinarkansas.org", Phone="5015819208",Website="Thecallinarkansas.org"},
            new Contact{OrganizationId=9, Street_Address="510 S. German Lane", City="Conway", Zip=72034,
                Email ="faye.shepherd@faulknercounty.org", Phone="5013285922",Website=""},
            new Contact{OrganizationId=10, Street_Address="1701 Donaghey", City="Conway", Zip=72032,
                Email ="mjones@caiinc.org", Phone="5013271701",Website="havenconway.org"}
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
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=2,Clothing=false,Education=false,Employment=true,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=3,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                Natural_Disaster =true,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=4,Clothing=false,Education=false,Employment=false,Finances=false,Food=true,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=true,Other_Resources_Text="Hygiene Items"},
            new Resource{OrganizationId=5,Clothing=false,Education=true,Employment=false,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text="Addiction"},
            new Resource{OrganizationId=6,Clothing=true,Education=true,Employment=false,Finances=true,Food=true,
                Natural_Disaster =false,Senior=false, Rent_Utilities=true,Medical_Prescription=false,
                Veterans =false,Housing=true, Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=7,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=true,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text="Gasoline Assistance"},
            new Resource{OrganizationId=8,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text="Foster and adoptive home recruitment and support"},
            new Resource{OrganizationId=9,Clothing=false,Education=true,Employment=false,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=false,Other_Resources=false,Other_Resources_Text=""},
            new Resource{OrganizationId=10,Clothing=false,Education=false,Employment=false,Finances=false,Food=false,
                Natural_Disaster =false,Senior=false, Rent_Utilities=false,Medical_Prescription=false,
                Veterans =false,Housing=true,Other_Resources=false,Other_Resources_Text=""},
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
            new Time{OrganizationId=1, Day=DayOfWeek.Monday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Tuesday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Wednesday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Thursday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=1, Day=DayOfWeek.Friday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("16:30")},
            new Time{OrganizationId=4, Day=DayOfWeek.Thursday, Repeat=0,Time_Start=TimeSpan.Parse("9:30"), Time_End=TimeSpan.Parse("13:30")},
            new Time{OrganizationId=5, Day=DayOfWeek.Monday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("9:00")},
            new Time{OrganizationId=5, Day=DayOfWeek.Tuesday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("9:00")},
            new Time{OrganizationId=5, Day=DayOfWeek.Wednesday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("9:00")},
            new Time{OrganizationId=5, Day=DayOfWeek.Thursday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("9:00")},
            new Time{OrganizationId=5, Day=DayOfWeek.Friday, Repeat=0,Time_Start=TimeSpan.Parse("8:00"), Time_End=TimeSpan.Parse("9:00")},
            new Time{OrganizationId=7, Day=DayOfWeek.Monday, Repeat=0,Time_Start=TimeSpan.Parse("9:00"), Time_End=TimeSpan.Parse("14:30")},
            new Time{OrganizationId=7, Day=DayOfWeek.Tuesday, Repeat=0,Time_Start=TimeSpan.Parse("9:00"), Time_End=TimeSpan.Parse("14:30")},
            new Time{OrganizationId=7, Day=DayOfWeek.Wednesday, Repeat=0,Time_Start=TimeSpan.Parse("9:00"), Time_End=TimeSpan.Parse("14:30")},
            new Time{OrganizationId=7, Day=DayOfWeek.Thursday, Repeat=0,Time_Start=TimeSpan.Parse("9:00"), Time_End=TimeSpan.Parse("14:30")},
            new Time{OrganizationId=7, Day=DayOfWeek.Friday, Repeat=0,Time_Start=TimeSpan.Parse("9:00"), Time_End=TimeSpan.Parse("14:30")}
            
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
