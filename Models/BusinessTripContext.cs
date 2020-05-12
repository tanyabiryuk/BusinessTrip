namespace BusinessTrip.Models
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class BusinessTripContext : DbContext
    {
        public BusinessTripContext(DbContextOptions<BusinessTripContext> options)
            :base(options)
            //: base("name=BusinessTripContext")
        {
            //Database.SetInitializer<businesstripContext>(new UniDBInitializer<businesstripContext>());
            //Initialize();
            Database.EnsureCreated();
        }

        public virtual DbSet<App_Fundation> App_Fundation { get; set; }
        public virtual DbSet<App_Transport> App_Transport { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Foundation> Foundation { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<User> User { get; set; }

        public void Initialize()
        {
            if (!this.Role.Any())
            {
                this.Role.Add(new Role { Id = 1, RoleName = "admin" });
                this.Role.Add(new Role { Id = 2, RoleName = "user" });
            }
        }

    }
}
