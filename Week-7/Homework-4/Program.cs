
List<Authors> authors = new List<Authors>(){
    new Authors{Id = 1, AuthorName ="Orhan Pamuk"},
    new Authors{Id = 2, AuthorName ="Elif Şafak"},
    new Authors{Id = 3, AuthorName ="Ahmet Ümit"},
};

List<Book> books = new List<Book>(){
    new Book{Id = 1, Title ="Kar", AuthorId=1},
    new Book{Id = 2, Title ="İstanbul", AuthorId=2},
    new Book{Id = 3, Title ="10 Minutes 38 Seconds in This Strange World ", AuthorId=3},
    new Book{Id = 4, Title ="Beyoğlu Rapsodisi", AuthorId=3},
};

// var Library = books.Join(authors,
//                         books => books.AuthorId,
//                         authors => authors.Id,
//                         (books, authors) => new
//                         {
//                             BookId = books.Id,
//                             AuthorsName = authors.AuthorName,
//                             BooksName = books.Title
//                         });

var Library = from author in authors
              join book in books
              on author.Id equals book.AuthorId
              select new{
                BookId = book.Id,
                AuthorName = author.AuthorName ,
                Title =book.Title,
              };


foreach (var library in Library)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(library);
    Console.ResetColor();
}