namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;

    //відношення багато до багатьох
    //зв'язок між заявкою і видом транспорту
    //Для одного відрядження кілька видів транспорту
    public partial class App_Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public App_Transport()
        {
            this.Application = new HashSet<Application>();
        }
        public int Id { get; set; }
        //Заявка
        public int ApplicationId { get; set; }
        //Транспорт
        public int TransportId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
        public virtual Transport TransportType { get; set; }
    }
}
