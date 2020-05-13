namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;
    //підстави для відрядження
    public partial class Foundation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Foundation()
        {
            this.App_Fundation = new HashSet<App_Fundation>();
        }
        public int Id { get; set; }
        //назва підстави
        public string Trip_Foundation { get; set; }

        //відношення багато-до-багатьох Заявка_Підстава (одна заявка може мати кілька підстав для відрядження)
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<App_Fundation> App_Fundation { get; set; }
    }
}
