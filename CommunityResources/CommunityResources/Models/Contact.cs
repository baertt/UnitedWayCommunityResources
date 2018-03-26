using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityResources.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        // Address

        public string Street_Address { get; set; }

        public string City { get; set; }

        public int Zip { get; set; }



        // Contact Information

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}
