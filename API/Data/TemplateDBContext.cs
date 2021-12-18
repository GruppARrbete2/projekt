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
   
  
        public DbSet<Output> Outputs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tenant>()
                .HasData(
                new Tenant { TenantID = 1, Namne = "Göran Svensson", Apartment = 1001, Tag = "1001A" },
                new Tenant { TenantID = 2, Namne = "Göran Andersson", Apartment = 1002, Tag = "1002A" },
                     new Tenant { TenantID = 3, Namne = "Jonas Andersson", Apartment = 1002, Tag = "1002B" },
                          new Tenant { TenantID = 4, Namne = "Stefan Andersson", Apartment = 1001, Tag = "1002B" }
    );
            builder.Entity<Output>()
                  .HasData(
                  new Output {ID = 1, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                  new Output { ID = 2, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖUT", Tag = "0301A", Person = "Ella Ahlström" },
                   new Output { ID = 3, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                   new Output { ID = 4, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                    new Output { ID = 5, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                     new Output { ID = 6, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                      new Output { ID = 7, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                       new Output { ID = 8, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                        new Output { ID = 9, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                         new Output { ID = 10, Time = DateTime.Now.Ticks, DörrBenämning = "Lägenhet", Code = "DÖIN", Tag = "0302A", Person = "Göran Ahlström" },
                          new Output { ID = 11, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                           new Output { ID = 12, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                            new Output { ID = 13, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                             new Output { ID = 14, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                              new Output { ID = 15, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                               new Output { ID = 16, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                                new Output { ID = 17, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                                 new Output { ID = 18, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                                  new Output { ID = 19, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                                  new Output { ID = 20, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                                  new Output { ID = 21, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" },
                                  new Output { ID = 22, Time = DateTime.Now.Ticks, DörrBenämning = "TVÄTT", Code = "DÖIN", Tag = "0301A", Person = "Ella Ahlström" }
        );
        }
    }
}
