
using Microsoft.EntityFrameworkCore;
using tickets.Models;

namespace tickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new{
            

            })
                base.OnModelCreating(modelBuilder);
        }

    }
}
