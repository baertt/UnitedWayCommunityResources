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

        public bool Natural_Disaster { get; set; }

        public bool Senior { get; set; }

        public bool Rent_Utilities { get; set; }

        public bool Medical_Prescription { get; set; }

        public bool Veterans { get; set; }

        public bool Other_Resources { get; set; }

        public string Other_Resources_Text { get; set; }


    }
}
