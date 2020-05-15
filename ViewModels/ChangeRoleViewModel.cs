using BusinessTrip.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.ViewModels
{
    public class ChangeRoleViewModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public List<Role> AllRoles { get; set; }
        public int UserRoleId { get; set; }
        public ChangeRoleViewModel()
        {
            AllRoles = new List<Role>();
        }
    }
}
