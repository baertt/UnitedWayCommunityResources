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
        
        public TimeSpan Time_Start { get; set; } //Use Military Time

        public TimeSpan Time_End { get; set; }

        public int Repeat { get; set; } // Week of month event occurs



        public DayOfWeek Day { get; set; }



        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }


    }
}
