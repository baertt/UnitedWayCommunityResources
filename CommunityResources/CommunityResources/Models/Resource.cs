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

        public int OrganizationId { get; set; }

        // Navigation property

        public Organization Organization { get; set; }



        // Resources Offered

        public bool Clothing { get; set; }

        public bool Education { get; set; }

        public bool Employment { get; set; }

        public bool Finances { get; set; }

        public bool Food { get; set; }

        [Display(Name = "Natural Disaster Assistance")]
        public bool Natural_Disaster { get; set; }

        [Display(Name = "Senior Assistance")]
        public bool Senior { get; set; }

        [Display(Name = "Rent and Utilities Assistance")]
        public bool Rent_Utilities { get; set; }

        [Display(Name = "Medical and Prescription Assistance")]
        public bool Medical_Prescription { get; set; }

        [Display(Name = "Veterans Services")]
        public bool Veterans { get; set; }

        [Display(Name = "Other Resources")]
        public bool Other_Resources { get; set; }

        [Display(Name = "Other Resources (Details)")]
        public string Other_Resources_Text { get; set; }


    }
}
