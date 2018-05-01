using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityResources.Models
{
    public class Resource 
    {
        [Key]
        public int Id { get; set; }



        // Foreign Key
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }

        // Navigation property

        public Organization Organization { get; set; }



        // Resources Offered

        public int Clothing { get; set; }

        public int Education { get; set; }

        public int Employment { get; set; }

        public int Finances { get; set; }

        public int Food { get; set; }

        public int Housing { get; set; }

        [Display(Name = "Natural Disaster Assistance")]
        public int Natural_Disaster { get; set; }

        [Display(Name = "Senior Assistance")]
        public int Senior { get; set; }

        [Display(Name = "Rent and Utilities Assistance")]
        public int Rent_Utilities { get; set; }

        [Display(Name = "Medical and Prescription Assistance")]
        public int Medical_Prescription { get; set; }

        [Display(Name = "Veterans Services")]
        public int Veterans { get; set; }

        [Display(Name = "Other Resources")]
        public int Other_Resources { get; set; }

        [Display(Name = "Other Resources (Details)")]
        public string Other_Resources_Text { get; set; }


    }
}
