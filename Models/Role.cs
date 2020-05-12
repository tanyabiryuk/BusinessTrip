namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role()
        {
            //this.User = new HashSet<User>();
        }
        public int Id { get; set; }
        public string RoleName { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<User> User { get; set; }
    }
}
