namespace BusinessTrip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    //заявка
    public partial class Application
    {
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        //ПІБ користувача
        public string Fullname { get; set; }
        //поточне місце праці
        public string Main_place_of_work { get; set; }
        //місце праці за сумісництвом
        public string Position_in_combination { get; set; }
        //тип відрядженя
        public string Type { get; set; }
        //мета відрядження
        public string Purpose { get; set; }
        //збереження заробітньої плати
        public string Saving_salary { get; set; }
        //місто відрядження
        public string Trip_city { get; set; }
        //країна відрядження
        public string Trip_country { get; set; }
        //установа відрядження
        public string Institution { get; set; }
        //дата початку відрядження
        public System.DateTime Start_date { get; set; }
        //дата завершення відрядження
        public System.DateTime End_date { get; set; }
        //маршрут відрядження
        public string Itinerary { get; set; }
        //вид транспорту
        //відношення багато-до-багатьох Заявка_Транспорт (Для одного відрадження кілька видів транспорту)
        public Nullable<int> App_transport_Id { get; set; }
        //Оплата відрядження
        public string Payment { get; set; }
        //підстава відрядження
        //відношення багато-до-багатьох Заявка_Підстава (Для одного відрадження кілька підстав)
        public int App_fundation_Id { get; set; }
        //адреса установи відрядження
        public string InstitutionLocation { get; set; }
        // Комментарий к заявке
        [Display(Name = "Коментар")]
        [MaxLength(200, ErrorMessage = "Превышена максимальная длина записи")]
        public string Comment { get; set; }
        // Статус заявки
        [Display(Name = "Статус")]
        public int Status { get; set; }

        // Перечисление для статуса заявки
        public enum RequestStatus
        {
            Open = 1,
            Distributed = 2,
            Proccesing = 3,
            Checking = 4,
            Closed = 5
        }
        // Перечисление для приоритета заявки
        public enum RequestPriority
        {
            Low = 1,
            Medium = 2,
            High = 3,
            Critical = 4
        }

        public virtual App_Fundation App_fundation { get; set; }
        public virtual App_Transport app_transport { get; set; }
        public virtual User User { get; set; }
    }
}
