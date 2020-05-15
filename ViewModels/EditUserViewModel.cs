using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.ViewModels
{
    public class EditUserViewModel
    {
        public int Id { get; set; }
        //прізвище
        public string LastName { get; set; }
        //ім'я
        public string FirstName { get; set; }
        //побатькові
        public string FatherName { get; set; }
        //роль
        public int RoleId { get; set; }
    }
}
