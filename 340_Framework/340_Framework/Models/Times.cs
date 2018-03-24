using System;
using System.ComponentModel.DataAnnotations;

namespace _340_Framework.Models
{


    public class Times
    {
        public int TimesId { get; set; }

        public TimeSpan Time_Start { get; set; }
        public TimeSpan Time_End { get; set; }
        public int Repeat { get; set; } // Week of month event occurs

        public DayOfWeek Day { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

    }
}
