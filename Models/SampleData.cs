using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.Models
{
    public static class SampleData
    {
        public static void Initialize(BusinessTripContext context)
        {
            if (context.Role.Where(r=>r.RoleName=="admin").ToList().Count==0)
            {
                context.Role.Add(new Role { RoleName = "admin" });
                context.SaveChanges();
            }
            var list = context.Role.Where(r => r.RoleName == "user").ToList();
            if (list.Count == 0)
            {
                context.Role.Add(new Role { RoleName = "user" });
                context.SaveChanges();
            }
            
        }
    }
}
