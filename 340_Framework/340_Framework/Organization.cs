﻿using System.ComponentModel.DataAnnotations;

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

        // Days Open
        public bool Monday1 { get; set; }
        public bool Monday2 { get; set; }
        public bool Monday3 { get; set; }
        public bool Monday4 { get; set; }
        public bool Tuesday1 { get; set; }
        public bool Tuesday2 { get; set; }
        public bool Tuesday3 { get; set; }
        public bool Tuesday4 { get; set; }
        public bool Wednesday1 { get; set; }
        public bool Wednesday2 { get; set; }
        public bool Wednesday3 { get; set; }
        public bool Wednesday4 { get; set; }
        public bool Thursday1 { get; set; }
        public bool Thursday2 { get; set; }
        public bool Thursday3 { get; set; }
        public bool Thursday4 { get; set; }
        public bool Friday1 { get; set; }
        public bool Friday2 { get; set; }
        public bool Friday3 { get; set; }
        public bool Friday4 { get; set; }
        public bool Saturday1 { get; set; }
        public bool Saturday2 { get; set; }
        public bool Saturday3 { get; set; }
        public bool Saturday4 { get; set; }
        public bool Sunday1 { get; set; }
        public bool Sunday2 { get; set; }
        public bool Sunday3 { get; set; }
        public bool Sunday4 { get; set; }

        // Hours Open (Military Time)
        public bool Monday600 { get; set; }
        public bool Monday630 { get; set; }
        public bool Monday700 { get; set; }
        public bool Monday730 { get; set; }
        public bool Monday800 { get; set; }
        public bool Monday830 { get; set; }
        public bool Monday900 { get; set; }
        public bool Monday930 { get; set; }
        public bool Monday1000 { get; set; }
        public bool Monday1030 { get; set; }
        public bool Monday1100 { get; set; }
        public bool Monday1130 { get; set; }
        public bool Monday1200 { get; set; }
        public bool Monday1230 { get; set; }
        public bool Monday1300 { get; set; }
        public bool Monday1330 { get; set; }
        public bool Monday1400 { get; set; }
        public bool Monday1430 { get; set; }
        public bool Monday1500 { get; set; }
        public bool Monday1530 { get; set; }
        public bool Monday1600 { get; set; }
        public bool Monday1630 { get; set; }
        public bool Monday1700 { get; set; }
        public bool Monday1730 { get; set; }
        public bool Monday1800 { get; set; }
        public bool Monday1830 { get; set; }
        public bool Monday1900 { get; set; }
        public bool Monday1930 { get; set; }
        public bool Monday2000 { get; set; }
        public bool Monday2030 { get; set; }
        public bool Monday24HR { get; set; }
        public bool Tuesday600 { get; set; }
        public bool Tuesday630 { get; set; }
        public bool Tuesday700 { get; set; }
        public bool Tuesday730 { get; set; }
        public bool Tuesday800 { get; set; }
        public bool Tuesday830 { get; set; }
        public bool Tuesday900 { get; set; }
        public bool Tuesday930 { get; set; }
        public bool Tuesday1000 { get; set; }
        public bool Tuesday1030 { get; set; }
        public bool Tuesday1100 { get; set; }
        public bool Tuesday1130 { get; set; }
        public bool Tuesday1200 { get; set; }
        public bool Tuesday1230 { get; set; }
        public bool Tuesday1300 { get; set; }
        public bool Tuesday1330 { get; set; }
        public bool Tuesday1400 { get; set; }
        public bool Tuesday1430 { get; set; }
        public bool Tuesday1500 { get; set; }
        public bool Tuesday1530 { get; set; }
        public bool Tuesday1600 { get; set; }
        public bool Tuesday1630 { get; set; }
        public bool Tuesday1700 { get; set; }
        public bool Tuesday1730 { get; set; }
        public bool Tuesday1800 { get; set; }
        public bool Tuesday1830 { get; set; }
        public bool Tuesday1900 { get; set; }
        public bool Tuesday1930 { get; set; }
        public bool Tuesday2000 { get; set; }
        public bool Tuesday2030 { get; set; }
        public bool Tuesday24HR { get; set; }
        public bool Wednesday600 { get; set; }
        public bool Wednesday630 { get; set; }
        public bool Wednesday700 { get; set; }
        public bool Wednesday730 { get; set; }
        public bool Wednesday800 { get; set; }
        public bool Wednesday830 { get; set; }
        public bool Wednesday900 { get; set; }
        public bool Wednesday930 { get; set; }
        public bool Wednesday1000 { get; set; }
        public bool Wednesday1030 { get; set; }
        public bool Wednesday1100 { get; set; }
        public bool Wednesday1130 { get; set; }
        public bool Wednesday1200 { get; set; }
        public bool Wednesday1230 { get; set; }
        public bool Wednesday1300 { get; set; }
        public bool Wednesday1330 { get; set; }
        public bool Wednesday1400 { get; set; }
        public bool Wednesday1430 { get; set; }
        public bool Wednesday1500 { get; set; }
        public bool Wednesday1530 { get; set; }
        public bool Wednesday1600 { get; set; }
        public bool Wednesday1630 { get; set; }
        public bool Wednesday1700 { get; set; }
        public bool Wednesday1730 { get; set; }
        public bool Wednesday1800 { get; set; }
        public bool Wednesday1830 { get; set; }
        public bool Wednesday1900 { get; set; }
        public bool Wednesday1930 { get; set; }
        public bool Wednesday2000 { get; set; }
        public bool Wednesday2030 { get; set; }
        public bool Wednesday24HR { get; set; }
        public bool Thursday600 { get; set; }
        public bool Thursday630 { get; set; }
        public bool Thursday700 { get; set; }
        public bool Thursday730 { get; set; }
        public bool Thursday800 { get; set; }
        public bool Thursday830 { get; set; }
        public bool Thursday900 { get; set; }
        public bool Thursday930 { get; set; }
        public bool Thursday1000 { get; set; }
        public bool Thursday1030 { get; set; }
        public bool Thursday1100 { get; set; }
        public bool Thursday1130 { get; set; }
        public bool Thursday1200 { get; set; }
        public bool Thursday1230 { get; set; }
        public bool Thursday1300 { get; set; }
        public bool Thursday1330 { get; set; }
        public bool Thursday1400 { get; set; }
        public bool Thursday1430 { get; set; }
        public bool Thursday1500 { get; set; }
        public bool Thursday1530 { get; set; }
        public bool Thursday1600 { get; set; }
        public bool Thursday1630 { get; set; }
        public bool Thursday1700 { get; set; }
        public bool Thursday1730 { get; set; }
        public bool Thursday1800 { get; set; }
        public bool Thursday1830 { get; set; }
        public bool Thursday1900 { get; set; }
        public bool Thursday1930 { get; set; }
        public bool Thursday2000 { get; set; }
        public bool Thursday2030 { get; set; }
        public bool Thursday24HR { get; set; }
        public bool Friday600 { get; set; }
        public bool Friday630 { get; set; }
        public bool Friday700 { get; set; }
        public bool Friday730 { get; set; }
        public bool Friday800 { get; set; }
        public bool Friday830 { get; set; }
        public bool Friday900 { get; set; }
        public bool Friday930 { get; set; }
        public bool Friday1000 { get; set; }
        public bool Friday1030 { get; set; }
        public bool Friday1100 { get; set; }
        public bool Friday1130 { get; set; }
        public bool Friday1200 { get; set; }
        public bool Friday1230 { get; set; }
        public bool Friday1300 { get; set; }
        public bool Friday1330 { get; set; }
        public bool Friday1400 { get; set; }
        public bool Friday1430 { get; set; }
        public bool Friday1500 { get; set; }
        public bool Friday1530 { get; set; }
        public bool Friday1600 { get; set; }
        public bool Friday1630 { get; set; }
        public bool Friday1700 { get; set; }
        public bool Friday1730 { get; set; }
        public bool Friday1800 { get; set; }
        public bool Friday1830 { get; set; }
        public bool Friday1900 { get; set; }
        public bool Friday1930 { get; set; }
        public bool Friday2000 { get; set; }
        public bool Friday2030 { get; set; }
        public bool Friday24HR { get; set; }
        public bool Saturday600 { get; set; }
        public bool Saturday630 { get; set; }
        public bool Saturday700 { get; set; }
        public bool Saturday730 { get; set; }
        public bool Saturday800 { get; set; }
        public bool Saturday830 { get; set; }
        public bool Saturday900 { get; set; }
        public bool Saturday930 { get; set; }
        public bool Saturday1000 { get; set; }
        public bool Saturday1030 { get; set; }
        public bool Saturday1100 { get; set; }
        public bool Saturday1130 { get; set; }
        public bool Saturday1200 { get; set; }
        public bool Saturday1230 { get; set; }
        public bool Saturday1300 { get; set; }
        public bool Saturday1330 { get; set; }
        public bool Saturday1400 { get; set; }
        public bool Saturday1430 { get; set; }
        public bool Saturday1500 { get; set; }
        public bool Saturday1530 { get; set; }
        public bool Saturday1600 { get; set; }
        public bool Saturday1630 { get; set; }
        public bool Saturday1700 { get; set; }
        public bool Saturday1730 { get; set; }
        public bool Saturday1800 { get; set; }
        public bool Saturday1830 { get; set; }
        public bool Saturday1900 { get; set; }
        public bool Saturday1930 { get; set; }
        public bool Saturday2000 { get; set; }
        public bool Saturday2030 { get; set; }
        public bool Saturday24HR { get; set; }
        public bool Sunday600 { get; set; }
        public bool Sunday630 { get; set; }
        public bool Sunday700 { get; set; }
        public bool Sunday730 { get; set; }
        public bool Sunday800 { get; set; }
        public bool Sunday830 { get; set; }
        public bool Sunday900 { get; set; }
        public bool Sunday930 { get; set; }
        public bool Sunday1000 { get; set; }
        public bool Sunday1030 { get; set; }
        public bool Sunday1100 { get; set; }
        public bool Sunday1130 { get; set; }
        public bool Sunday1200 { get; set; }
        public bool Sunday1230 { get; set; }
        public bool Sunday1300 { get; set; }
        public bool Sunday1330 { get; set; }
        public bool Sunday1400 { get; set; }
        public bool Sunday1430 { get; set; }
        public bool Sunday1500 { get; set; }
        public bool Sunday1530 { get; set; }
        public bool Sunday1600 { get; set; }
        public bool Sunday1630 { get; set; }
        public bool Sunday1700 { get; set; }
        public bool Sunday1730 { get; set; }
        public bool Sunday1800 { get; set; }
        public bool Sunday1830 { get; set; }
        public bool Sunday1900 { get; set; }
        public bool Sunday1930 { get; set; }
        public bool Sunday2000 { get; set; }
        public bool Sunday2030 { get; set; }
        public bool Sunday24HR { get; set; }


        // Additional Comments
        public string Additional_Comments { get; set; }
    }
}