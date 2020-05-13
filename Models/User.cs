namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Application = new HashSet<Application>();
        }
        public int Id { get; set; }
        //прізвище
        public string LastName { get; set; }
        //ім'я
        public string FirstName { get; set; }
        //побатькові
        public string FatherName { get; set; }
        //ел пошта
        public string Email { get; set; }
        //роль
        public int RoleId { get; set; }
        //пароль
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
        public virtual Role Role { get; set; }
    }
}
