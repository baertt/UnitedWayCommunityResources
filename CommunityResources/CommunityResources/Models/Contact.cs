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

        [Display(Name ="Street Address")]
        public string Street_Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(5)]
        public string Zip { get; set; }

        [Display(Name = "Address")]
        public string AddressFull
        {
            get
            {
                return Street_Address + '\n'+ City + ", AR " + Zip;
            }
        }

        [Display(Name = "Area")]
        public string Town_Address
        {
            get
            {
                return City + ", AR " + Zip;
            }
        }



        // Contact Information

        //If we want to validate email formats...
        //[RegularExpression(@"^[A - Z0 - 9._ % +-] +@(?:[A - Z0 - 9 -] +\.)+[A-Z]{2,}$")]
        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^[2 - 9]\d{2}-\d{3}-\d{4}$")]
        public string Phone { get; set; }

        
        public string Website { get; set; }
    }
}
