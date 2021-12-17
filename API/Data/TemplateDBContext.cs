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
        public DbSet<Output> Outputs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tenant>()
                .HasData(
                new Tenant { TenantID = 1, Namne = "Göran Svensson", Apartment = 1001, Tag = "1001A" },
                new Tenant { TenantID = 2, Namne = "Göran Andersson", Apartment = 1002, Tag = "1002A" }
        );
            builder.Entity<Door>()
                  .HasData(
                  new Door { DoorID = 1, DörrBenämning = "Tvätt", Explanation = "Dörr mot tvättstuga" },
                  new Door { DoorID = 2, DörrBenämning = "LGH", Explanation = "Dörr till lägenhet" }

        );
            builder.Entity<Output>()
                  .HasData(
                  new Output { ID = 1, Time = DateTime.Now.TimeOfDay,DörrBenämning = "TVÄTT", Code = "DÖIN" , Tag = "0301A" , Person = "Ella Ahlström" , CodeExplation = "Öppnade dörr till tvätten 0301 inifrån" },
                  new Output { ID = 2, Time = DateTime.Now.TimeOfDay, DörrBenämning = "TVÄTT", Code = "DÖUT", Tag = "0301A", Person = "Ella Ahlström", CodeExplation = "Öppnade dörr till tvätten 0301 utifrån" },
                   new Output { ID = 3, Time = DateTime.Now.TimeOfDay, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström", CodeExplation = "Öppnade dörr till lägenhet 0301 utifrån" }
        );
        }
    }
}
