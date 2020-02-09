using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nVisionGlobalProject_ArmandoRamirez.Models
{
    public class PersonViewModel
    {
        [Required(ErrorMessage = "Please enter your firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your lastname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid telephone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Please enter your gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your ocupation")]
        public string Ocupation { get; set; }
    }
}
