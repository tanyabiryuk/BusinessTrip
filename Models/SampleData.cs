using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.Models
{
    //заповнення бази початковими даними
    public static class SampleData
    {
        public static void Initialize(BusinessTripContext context)
        {
            //якщо в базі неемає ролі admin, то додати
            if (context.Role.Where(r=>r.RoleName=="admin").ToList().Count==0)
            {
                context.Role.Add(new Role { RoleName = "admin" });
                context.SaveChanges();
            }
            //якщо в базі неемає ролі user, то додати
            if (context.Role.Where(r => r.RoleName == "user").ToList().Count == 0)
            {
                context.Role.Add(new Role { RoleName = "user" });
                context.SaveChanges();
            }
            
        }
    }
}
