
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace API.Data
{
    public class TemplateDBContext : DbContext
    {
        public TemplateDBContext(DbContextOptions<TemplateDBContext> options)
            : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<DoorOpened> DoorsOpened { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tenant>()
                .HasData(
                new Tenant { TenantID = 1, Namne = "Göran Svensson", Apartment = 1001, Tag = "1001A" },
                new Tenant { TenantID = 2, Namne = "Göran Andersson", Apartment = 1002, Tag = "1002A" }
);
            builder.Entity<Door>()
                  .HasData(
                  new Door { DoorID = 1, DörrBenämning="Tvätt", Explanation="Dörr mot tvättstuga"},
                  new Door { DoorID = 2, DörrBenämning="LGH", Explanation="Dörr till lägenhet"}
  );


        }
    }
}
