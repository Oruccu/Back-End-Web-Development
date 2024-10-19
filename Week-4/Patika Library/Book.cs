class Book
{
    private string _name;
    private string _authorName;
    private string _authorSurname;
    private int _bookPage;
    private string _publisher;
    private DateTime _dateRegistration;

    public string Name { get => _name; set => _name = value; }
    public string AuthorName { get => _authorName; set => _authorName = value; }
    public string AuthorSurname { get => _authorSurname; set => _authorSurname = value; }
    public int BookPage
    {
        get => _bookPage;
        set
        {
            if (value < 0)
                Console.WriteLine("Sayfa sayısı sıfırdan küçük olamaz");
            else
                _bookPage = value;
        }
    }

    public string Publisher { get => _publisher; set => _publisher = value; }
    public DateTime DateRegistration { get => _dateRegistration; set => _dateRegistration = value; }
    public Book(string name, string authorName, string authorSurname, int bookPage, string publisher)
    {
        _name = name;
        _authorName = authorName;
        _authorSurname = authorSurname;
        _bookPage = bookPage;
        _publisher = publisher;
        _dateRegistration = DateTime.Now;
    }
    public Book(){
        _dateRegistration = DateTime.Now;
    }

    public void SaveBook(){
        Console.WriteLine();
        Console.Write($"{AuthorName} {AuthorSurname}'in {BookPage} sayfalık, {Publisher} yayınevinden çıkan  {Name} kitabını oluşturunuz.");
        Console.WriteLine($" Oluşturma tarihi: {DateRegistration}");
        Console.WriteLine("-----------------------------");
    }
}