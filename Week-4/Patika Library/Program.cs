Book book1 = new Book();
book1.Name = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.BookPage = 398;
book1.Publisher = "Remzi Kitabevi";
book1.SaveBook();

Book book2 = new Book("Bir Kitap", "Ayşe" , "Nur" , 320, "Alfa");
book2.SaveBook();

Book book3 = new Book("Son Kitap", "Fatma" , "Nur" , 100, "Delta");
book3.SaveBook();
