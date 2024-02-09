using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Description = "Kid Story Books", DisplayOrder = 1, Name = "Story" },
                new Category { Id = 2, Description = "SciFI Books", DisplayOrder = 2, Name = "SciFi" },
                new Category { Id = 3, Description = "Religion Books", DisplayOrder = 3, Name = "Religion" }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
