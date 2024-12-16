namespace BootcampEntity;

public class Author
{
    public int Id { get; set; }
    public DateTime DateofBirth { get; set; }
    public List<Book> Books{ get; set; }

}
