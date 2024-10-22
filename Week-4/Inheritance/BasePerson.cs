class BasePerson
{
    private string name;
    private string surname;
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public void baseInfo()
    {
        Console.WriteLine($"Adınız: {Name} Soyadınız: {Surname}");
    }
}

class Student : BasePerson
{
    private int number;
    public int Number { get => number; set => number = value; }
    public void studentInfo()
    {
        Console.WriteLine($"{Name} {Surname}'nin öğrenci numarası: {Number}");
    }
}

class Teacher : BasePerson
{
    private int salary;
    public int Salary { get => salary; set => salary = value; }
    public void teacherInfo()
    {
        Console.WriteLine($"{Name} {Surname}'nin öğretmenin numarası: {Salary} TL'dir.");
    }
}

