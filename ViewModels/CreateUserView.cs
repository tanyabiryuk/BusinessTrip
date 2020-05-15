using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.ViewModels
{
    public class CreateUserView
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Поле обов'язкове")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове")]
        public string FatherName { get; set; }


        [Required(ErrorMessage = "Поле обов'язкове")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
