Person person = new Person();
person.Name1= "Ayşe";
person.Surname1= "Nur";
person.BirthDate1= new DateTime(1999, 4,11);
person.PersonWriteConsole();

//************************************************//

Person person2 = new Person("Fatma", "Nur", new DateTime(2000, 7,4));
person2.PersonWriteConsole();

class Person{
    private string name;
    private string surname;
    private DateTime birthDate;

    public string Name1 { get => name; set => name = value; }
    public string Surname1 { get => surname; set => surname = value; }
    public DateTime BirthDate1 { get => birthDate; set => birthDate = value; }
    public Person(){}
    public Person(string name, string surname, DateTime birthDate)
    {
        this.name = name;
        this.surname = surname;
        this.birthDate = birthDate;
    }
    public void PersonWriteConsole(){
        Console.WriteLine("**********************");
        Console.WriteLine("Kullanıcı adı: {0}", name);
        Console.WriteLine("Kullanıcı adı: {0}", surname);
        Console.WriteLine("Kullanıcı adı: {0}", birthDate.ToShortDateString());
    }
}