namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Application
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Main_place_of_work { get; set; }
        public string Position_in_combination { get; set; }
        public string Type { get; set; }
        public string Purpose { get; set; }
        public string Saving_salary { get; set; }
        public string Trip_city { get; set; }
        public string Trip_country { get; set; }
        public string Institution { get; set; }
        public System.DateTime Start_date { get; set; }
        public System.DateTime End_date { get; set; }
        public string Itinerary { get; set; }
        public Nullable<int> App_transport_Id { get; set; }
        public string Payment { get; set; }
        public int App_fundation_Id { get; set; }
        public string InstitutionLocation { get; set; }

        public virtual App_Fundation App_fundation { get; set; }
        public virtual App_Transport app_transport { get; set; }
        public virtual User User { get; set; }
    }
}
