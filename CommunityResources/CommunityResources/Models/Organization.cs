using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityResources.Models
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Requirements

        public bool Photo_ID { get; set; }

        public bool Other_Requirements { get; set; }

        public string Other_Requirements_Text { get; set; }



        // Appointments

        public bool Appointments_Availible { get; set; }

        public bool Appointments_Required { get; set; }

        public string Additional_Comments { get; set; }

        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Time> Times { get; set; }
        public ICollection<Resource> Resources { get; set; }
        

    }
}
