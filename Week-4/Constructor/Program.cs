Baby baby1 = new Baby();
baby1.Name = "Ayse";
baby1.Surname = "Nur";
baby1.BabyIsBorn();

//**********************//
Baby baby2 = new Baby("Fatma", "Nur", new DateTime(1999, 4, 17));
baby2.BabyIsBorn();


class Baby
{
    private string _name;
    private string _surname;
    private DateTime _birthDate;

    public string Name { get => _name; set => _name = value; }
    public string Surname { get => _surname; set => _surname = value; }
    public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }

    public Baby()
    {
        this._name = "";
        this._surname = "";
        this._birthDate = DateTime.Now;
    }
    public Baby(string _name, string _surname, DateTime _birthDate)
    {
        this._name = _name;
        this._surname = _surname;
        this._birthDate = _birthDate;
    }
    public void BabyIsBorn()
    {
        Console.WriteLine("Ad: " + _name);
        Console.WriteLine("Soyad: " + _surname);
        Console.WriteLine("Doğum Tarihi: " + _birthDate.ToString("dd.MM.yyyy HH:mm:ss"));
        Console.WriteLine("Ingaaaa");
        Console.WriteLine("-----------------------------");
    }


}