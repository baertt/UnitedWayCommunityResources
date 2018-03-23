using System.ComponentModel.DataAnnotations;

namespace _340_Framework
{
    public class Resources
    {
        public int Id { get; set; }

        // Foreign Key
        public int OrgsId { get; set; }
        // Navigation property
        public Models.Organization Orgs { get; set; }

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