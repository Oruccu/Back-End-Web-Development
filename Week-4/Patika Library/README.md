## Book Class Project
### Description
This project demonstrates the implementation of a Book class in C#. The class includes properties such as `Name`, `AuthorName`, `AuthorSurname`, `BookPage`, Publisher, and DateRegistration. It has both a default constructor and a parameterized constructor. The SaveBook method prints the details of the book to the console.
## Features
* Default Constructor: Initializes the properties with default values and sets the DateRegistration to the current date.
* Parameterized Constructor: Initializes the properties with given values.
* Method SaveBook(): Prints the book's details to the console.

## Getting Started
### Prerequisites
* .NET Framework installed on your system.

**Running the Example**
**1.** Clone or download the repository.
**2.** Open the solution file in Visual Studio or any C# IDE.
**3.** Build the solution to restore any missing dependencies.
**4.** Run the Program class which contains the Main method.

### Code Overview

**Book Class**

```Csharp

public class Book {
    private string _name;
    private string _authorName;
    private string _authorSurname;
    private int _bookPage;
    private string _publisher;
    private DateTime _dateRegistration;

    public string Name { get => _name; set => _name = value; }
    public string AuthorName { get => _authorName; set => _authorName = value; }
    public string AuthorSurname { get => _authorSurname; set => _authorSurname = value; }
    public int BookPage {
        get => _bookPage;
        set {
            if (value < 0)
                Console.WriteLine("Sayfa sayısı sıfırdan küçük olamaz");
            else
                _bookPage = value;
        }
    }
    public string Publisher { get => _publisher; set => _publisher = value; }
    public DateTime DateRegistration { get => _dateRegistration; set => _dateRegistration = value; }

    public Book(string name, string authorName, string authorSurname, int bookPage, string publisher, DateTime dateRegistration) {
        _name = name;
        _authorName = authorName;
        _authorSurname = authorSurname;
        _bookPage = bookPage;
        _publisher = publisher;
        _dateRegistration = dateRegistration;
    }

    public Book() {
        _dateRegistration = DateTime.Now;
    }

    public void SaveBook() {
        Console.WriteLine();
        Console.Write($"{AuthorName} {AuthorSurname}'in {BookPage} sayfalık, {Publisher} yayınevinden çıkan {Name} kitabını oluşturunuz.");
        Console.WriteLine($" Oluşturma tarihi: {DateRegistration.ToString("dd.MM.yyyy HH:mm:ss")}");
        Console.WriteLine("-----------------------------");
    }
}
```

**Program Class**

```Csharp
class Program {
    static void Main(string[] args) {
        // İlk kitap nesnesi - varsayılan constructor ile
        Book book1 = new Book();
        book1.Name = "Adı Aylin";
        book1.AuthorName = "Ayşe";
        book1.AuthorSurname = "Kulin";
        book1.BookPage = 398;
        book1.Publisher = "Remzi Kitabevi";
        book1.SaveBook();

        Console.WriteLine("************************");

        // İkinci kitap nesnesi - parametreli constructor ile
        DateTime registrationDate = new DateTime(2023, 11, 3);
        Book book2 = new Book("Bir Kitap", "Ayşe", "Nur", 320, "Alfa", registrationDate);
        book2.SaveBook();
    }
}
```

### Notes
* Ensure the dates are entered in the correct format.
* The Book class includes both a default constructor and a parameterized constructor for flexibility.

### Authors

Ayşe Nur

