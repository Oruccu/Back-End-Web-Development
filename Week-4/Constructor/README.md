# BABY IS BORN

## Description

In this project, we will keep newborn baby information using the Baby Class method. The class includes properties for `name`, `surname`, and `birthDate`. It has both a default constructor and a parameterized constructor. The `BabyIsBorn` method prints the details of the baby to the console.

### Features

- Default Constructor: Initializes the properties with default values.
- Parameterized Constructor: Initializes the properties with given values.
- Method BabyIsBorn(): Prints the baby's details.

### Getting Started

### Prerequisites

- .NET Framework (Version 4.7.2 or higher)
- An IDE or text editor that supports C# (e.g., Visual Studio, Visual Studio Code)

**Installing**

Clone the repository to your local machine:

```Sh
git clone https://github.com/Oruccu/Back-End-Web-Development.git
```

Navigate to the project directory:

```Sh
cd Week-4
cd Constructor
```

**Running the Program**

Open your IDE or terminal, and compile the program. The program will create two Baby objects and display their details on the console.

### Code Overview

**Baby Class**

```CSharp
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
```

**Main Program**

```CSharp
    Baby baby1 = new Baby();
    baby1.Name = "Ayse";
    baby1.Surname = "Nur";
    baby1.BabyIsBorn();

    DateTime birthDate = new DateTime(1999, 4, 17);
    Baby baby2 = new Baby("Fatma", "Nur", birthDate);
```
