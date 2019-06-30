using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExpressoApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        //making the name mandatory 
        //and everything below
        [Required]
        public string  Name { get; set; }

        //fixing the e-mail 
        //so the user doesn't use wrong format
        //RegularExpression
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email in not valid")]
        public string Email { get; set; }

        //allowing the user to add just the number  
        //RegularExpresson for just numbers 
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number in not valid")]
        public string Phone { get; set; }

        [Required]
        public int TotalPeople { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        //[DataType(DataType.Time)]
        public string Time { get; set; }

    }
}
