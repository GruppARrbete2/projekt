
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

        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Template>()
                .HasData(
                new Template { TemplateID = 1, TemplateString = "test1" },
                new Template { TemplateID = 2, TemplateString = "test2" }
);

           
        }
    }
}
