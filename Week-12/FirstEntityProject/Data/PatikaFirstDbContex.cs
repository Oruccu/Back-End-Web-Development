using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityProject;
public class PatikaFirstDbContex : DbContext
{
    public DbSet<GameData> GameDatas { get; set; }
    public DbSet<MovieData> MovieDatas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=*****;Database=PatikaCodeFirstDb1");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameData>(entity =>
        {
            entity.ToTable("Games");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entity.Property(x => x.Platform).IsRequired().HasMaxLength(100);
            entity.Property(x => x.Rating).IsRequired().HasColumnType("decimal(18,2)");
        });
        modelBuilder.Entity<MovieData>(entity =>
        {
            entity.ToTable("Movies");
            entity.Property(x => x.Title).IsRequired().HasMaxLength(100);
            entity.Property(x => x.ReleaseYear).IsRequired();
        });

        modelBuilder.Entity<GameData>().HasData
        (
            new GameData() { Id = 1, Name = "The Witcher 3: Wild Hunt", Platform = "PC" },
            new GameData() { Id = 2, Name = "Red Dead Redemption 2", Platform = "PlayStation" },
            new GameData() { Id = 3, Name = "Halo Infinite", Platform = "Xbox" },
            new GameData() { Id = 4, Name = "Super Mario Odyssey", Platform = "Nintendo Switch" },
            new GameData() { Id = 5, Name = "Cyberpunk 2077", Platform = "PC" }
        );

        modelBuilder.Entity<MovieData>().HasData
        (
            new MovieData() { Id = 1, Title = "Inception", Genre = "Science Fiction", ReleaseYear = 2010 },
            new MovieData() { Id = 2, Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972 },
            new MovieData() { Id = 3, Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 },
            new MovieData() { Id = 4, Title = "Pulp Fiction", Genre = "Crime", ReleaseYear = 1994 },
            new MovieData() { Id = 5, Title = "Forrest Gump", Genre = "Drama", ReleaseYear = 1994 }
        );
    }

}
