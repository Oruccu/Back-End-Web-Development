namespace ToDoWeb;
using Microsoft.EntityFrameworkCore;
public class TaskDbContext: DbContext
{
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=Servers; Port=5432; UserName=postgres; Password:Ayse25175; DatabaseDb:Todo");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
        .Entity<Task>()
        .Property(t => t.Id)
        .HasMaxLength(400);

        modelBuilder
        .Entity<Task>()
        .HasData(
            new Task() { Id = 1, Title="Swimming", done=true },
            new Task() { Id = 2, Title="New Job", done=true },
            new Task() { Id = 3, Title="Married", done=true },
            new Task() { Id = 4, Title="Swimming", done=true }
        );
    }

}
