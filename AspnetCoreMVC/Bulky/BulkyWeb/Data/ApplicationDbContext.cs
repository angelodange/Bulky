using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base  (options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 10, Name = "Action1", DisplayOrder = 1 },
                new Category { CategoryId = 11, Name = "Action2", DisplayOrder = 2 },
                new Category { CategoryId = 12, Name = "Action3", DisplayOrder = 3 }
                );
        }
    }
}
