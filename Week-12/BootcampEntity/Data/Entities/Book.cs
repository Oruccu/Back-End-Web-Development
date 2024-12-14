using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace BootcampEntity;

[Table("Books")]
[Index(nameof(Author))]
public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    [StringLength(100)]  
    public string Author { get; set; }

    public int PublicationYear { get; set; }

    [Column("BookPrice", TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    
    [Column("LastBorrowed")]
    public DateTime? LastBorrowedDate { get; set; }
    public List<Review> Reviews { get; set; }
}
