namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transport()
        {
            this.App_transport = new HashSet<App_Transport>();
        }
        public int Id { get; set; }
        //вид транспорту для відрядження
        public string TransportType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<App_Transport> App_transport { get; set; }
    }
}
