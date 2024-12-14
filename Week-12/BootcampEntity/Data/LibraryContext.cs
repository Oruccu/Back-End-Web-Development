using Microsoft.EntityFrameworkCore;

namespace BootcampEntity;

public class LibraryContext: DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Review> Reviews {get; set; }
    

}
