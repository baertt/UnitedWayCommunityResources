using System.ComponentModel.DataAnnotations;

namespace _340_Framework
{
    public class Organization
    {
        public int Id { get; set; }

        // Name
        [Required, StringLength(100)]
        public string Name { get; set; }

        // Address
        public string Street_Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

        // Contact Information
        public string Email { get; set; }
        public int Phone { get; set; }

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

        // Requirements
        public bool Photo_ID { get; set; }
        public bool Other_Requirements { get; set; }
        public string Other_Requirements_Text { get; set; }

        // Appointments
        public bool Appointments_Availible { get; set; }
        public bool Appointments_Required { get; set; }




    }
}