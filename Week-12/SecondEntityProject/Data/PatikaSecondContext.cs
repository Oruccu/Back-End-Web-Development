using Microsoft.EntityFrameworkCore;

namespace SecondEntityProject;

public class PatikaSecondContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=Ayse25175;Database=PatikaCodeFirstDb2");
    }
   protected override void OnModelCreating(ModelBuilder modelBuilder) { 

     modelBuilder.Entity<User>()
            .HasMany(u => u.Posts)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
            
     }
}
