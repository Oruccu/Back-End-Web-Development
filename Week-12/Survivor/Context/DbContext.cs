using Microsoft.EntityFrameworkCore;
using SurvivorProject.Model.Entity;

namespace SurvivorProject.Model.Context
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=*****;Database=PatikaCodeFirstDb1");
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitors> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Category - Competitor ilişkisi (One-to-Many)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Competitors)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}