﻿using System;
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
        [Required]
        public string Name { get; set; }

        // Requirements
        [Display(Name = "Photo ID is Required")]
        public bool Photo_ID { get; set; }
        [Display(Name = "There are other requirements")]
        public bool Other_Requirements { get; set; }
        [Display(Name = "Other Requirements")]
        public string Other_Requirements_Text { get; set; }



        // Appointments
        [Display(Name = "Appointments are Availible")]
        public bool Appointments_Availible { get; set; }
        [Display(Name = "Appointments are Required")]
        public bool Appointments_Required { get; set; }
        [Display(Name = "Additional Comments")]
        public string Additional_Comments { get; set; }

        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Time> Times { get; set; }
        public ICollection<Resource> Resources { get; set; }
        

    }
}