﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.ViewModels
{
    public class EditApplicationViewModel
    {
        public int userId { get; set; }
        public int Id { get; set; }
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
        public List<string> App_transport { get; set; }
        //Оплата відрядження
        public string Payment { get; set; }
        //підстава відрядження
        //відношення багато-до-багатьох Заявка_Підстава (Для одного відрадження кілька підстав)
        public List<string> App_fundation { get; set; }
        //адреса установи відрядження
        public string InstitutionLocation { get; set; }

        public List<string> Allfundations { get; set; }
        public List<string> Alltransports { get; set; }

    }
}
