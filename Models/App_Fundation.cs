namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;

    //відношення багато до багатьох
    //зв'язок між заявкою і підставою
    //Для одного відрядження кілька підстав
    public partial class App_Fundation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public App_Fundation()
        {
            this.Application = new HashSet<Application>();
        }

        public int Id { get; set; }
        //заявка
        public int ApplicationId { get; set; }
        //підстава
        public int FundationId { get; set; }

        public virtual Foundation Foundation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
    }
}
