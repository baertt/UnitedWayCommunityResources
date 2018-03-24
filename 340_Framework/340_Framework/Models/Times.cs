using System.ComponentModel.DataAnnotations;

namespace _340_Framework.Models
{

    public enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public class Times
    {
        public int Id { get; set; }

        public int Time_Start { get; set; }
        public int Time_End { get; set; }
        public int Repeat { get; set; } // Week of month event occurs

        public Day Day { get; set; }


        public Organization Organization { get; set; }

    }
}
