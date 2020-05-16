namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Application = new HashSet<Application>();
        }
        public int Id { get; set; }
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

   

        ////прізвище
        //public string LastName { get; set; }
        ////ім'я
        //public string FirstName { get; set; }
        ////побатькові
        //public string FatherName { get; set; }
        ////ел пошта
        //public string Email { get; set; }

        ////пароль
        //public string Password { get; set; }
        //роль
        public int RoleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
        public virtual Role Role { get; set; }
    }
}
