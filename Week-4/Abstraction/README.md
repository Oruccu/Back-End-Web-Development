# Employee Class Project

## Description

This project demonstrates the implementation of an `Employee` abstract class and its derived classes (`ProjectManager`, `SoftwareDeveloper`, and `SalesRepresentative`) in C#. Her çalışanın adı, soyadı ve rolünü belirten metodlar bulunmaktadır. Proje kapsamında her çalışanın `department` ve `role` metodları kendine özgü işlemleri yapmaktadır.

## Features

- **Employee Class**: Abstract base class with `name` and `surname` properties. Includes abstract methods `department()` and `role()`.
- **ProjectManager Class**: Inherits from `Employee` and overrides `department()` and `role()` methods.
- **SoftwareDeveloper Class**: Inherits from `Employee` and overrides `department()` and `role()` methods.
- **SalesRepresentative Class**: Inherits from `Employee` and overrides `department()` and `role()` methods.

## Getting Started

### Prerequisites

- .NET Framework installed on your system.

### Running the Example

1. Clone or download the repository.
2. Open the solution file in Visual Studio Code or any C# IDE.
3. Build the solution to restore any missing dependencies.
4. Run the `Program` class which contains the `Main` method.

### Code Overview

#### Employee Class

```csharp
public abstract class Employee {
    public string name;
    public string surname;

    public abstract void department();
    public abstract void role();
}
```

### Program Class

```Csharp
ProjectManager projectManager = new ProjectManager();
projectManager.name = "Ayşe";
projectManager.surname = "Nur";
projectManager.department();
projectManager.role();

Console.WriteLine("-----------------------------");
```

