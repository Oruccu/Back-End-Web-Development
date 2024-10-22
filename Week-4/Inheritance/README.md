# BasePerson Class Project

## Description

This project demonstrates the implementation of a `BasePerson` class and its derived classes `Student` and `Teacher` in C#. The classes include properties such as `Name`, `Surname`, `Number`, and `Salary`. The methods `baseInfo()`, `studentInfo()`, and `teacherInfo()` are used to print details to the console.

## Features

- **BasePerson Class**: Base class with `Name` and `Surname` properties.
- **Student Class**: Inherits from `BasePerson` and includes `Number` property.
- **Teacher Class**: Inherits from `BasePerson` and includes `Salary` property.
- **Methods**: `baseInfo()`, `studentInfo()`, and `teacherInfo()` print the respective details to the console.

## Getting Started

### Prerequisites

- .NET Framework installed on your system.

### Running the Example

1. Clone or download the repository.
2. Open the solution file in Visual Studio Code or any C# IDE.
3. Build the solution to restore any missing dependencies.
4. Run the `Program` class which contains the `Main` method.

### Code Overview

#### BasePerson Class

```csharp
class BasePerson {
    private string name;
    private string surname;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }

    public void baseInfo() {
        Console.WriteLine($"Adınız: {Name} Soyadınız: {Surname}");
    }
}
```

**Student Class**
```csharp
class Student : BasePerson {
    private int number;

    public int Number { get => number; set => number = value; }

    public void studentInfo() {
        Console.WriteLine($"{Name} {Surname}'nin öğrenci numarası: {Number}");
    }
}
```
**Program Class**

```csharp
Student student = new Student();
student.Name = "Ayse";
student.Surname = "Nur";
student.Number = 12345;
student.studentInfo();
Teacher teacher = new Teacher();
teacher.Name = "Fatma";
teacher.Surname = "Nur";
teacher.Salary = 123489;
teacher.teacherInfo();
```

### Notes

- Ensure the properties are set correctly before calling the info methods.

### Authors

- Ayşe Nur
