namespace BusinessTrip.Models
{
    using BusinessTripMyVersion.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class BusinessTripContext : DbContext
    {
        public BusinessTripContext(DbContextOptions<BusinessTripContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<App_Fundation> App_Fundation { get; set; }
        public virtual DbSet<App_Transport> App_Transport { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Foundation> Foundation { get; set; }
        public DbSet<Lifecycle> Lifecycles { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<User> User { get; set; }

        

    }
}
