using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CommunityResources.Models
{
    public class Time
    {
        [Key]
        public int TimesId { get; set; }

        [Display(Name = "Opening Time")]
        public string Time_Start { get; set; } //Use Military Time
        
        [Display(Name = "Closing Time")]
        public string Time_End { get; set; }
        
        [Display(Name = "Week of the Month")]
        public int Repeat { get; set; } // Week of month event occurs


        [Required]
        public string Day { get; set; }


        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

       
    }
}
