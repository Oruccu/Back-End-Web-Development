using BootcampEntity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BooksController(LibraryContext context){
            _context = context;
        }

        [HttpPost]
        public ActionResult<Book> Post([FromBody] Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }
        [HttpPut]
        public IActionResult Put(int id, [FromBody] Book book)
        {
            var current =_context.Books.FirstOrDefault(b => b.Id == id);
            if(current==null) return NotFound();

            current.Title = book.Title;
            current.LastBorrowedDate = book.LastBorrowedDate;
            current.Price = book.Price;
            current.CategoryId = book.CategoryId;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet]
        public ActionResult<List<Book>> GetAll(){

            var recentBooks = _context.Books
                              .Where(b => b.PublicationYear > 2020)
                              .OrderByDescending(b => b.PublicationYear)
                              .Take(20)
                              .ToList();   
            return Ok(recentBooks);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
            var current = _context.Books.FirstOrDefault(b => b.Id==id);
            if(current==null) return NotFound();
            _context.Books.Remove(current);
            _context.SaveChanges();

            return NoContent();
        }


    }
}