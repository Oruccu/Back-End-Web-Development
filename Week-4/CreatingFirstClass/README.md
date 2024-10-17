# Person Class Project
## Description
This project demonstrates the implementation of a Person class in C#. The class includes properties for name, surname, and birthDate. It has both a default constructor and a parameterized constructor. The PersonWriteConsole method prints the details of the person to the console.

## Getting Started
## Prerequisites
* .NET Framework (Version 4.7.2 or higher)
* An IDE or text editor that supports C# (e.g., Visual Studio, Visual Studio Code)

**Installing**

Clone the repository to your local machine:
```Sh
git clone https://github.com/Oruccu/Back-End-Web-Development.git
```

Navigate to the project directory:

```Sh
cd Week-4
cd PersonClassProject
```

**Running the Program**

Open your IDE or terminal, and compile the program. The program will create two ```Person``` objects and display their details on the console.

***Example Usage***
```Csharp
Person Student = new Person();
Student.Name1= "Ayşe";
Student.Surname1= "Nur";
Student.BirthDate1= new DateTime(1999, 4,11);
Student.PersonWriteConsole();

//************************************************//

Person Teacher = new Person("Fatma", "Nur", new DateTime(2000, 7,4));
Teacher.PersonWriteConsole();
```

***Output***

```Sh
**********************
Kullanıcı adı: Ayşe
Kullanıcı soyadı: Nur
Doğum tarihi: 11.04.1999
**********************
Kullanıcı adı: Fatma
Kullanıcı soyadı: Nur
Doğum tarihi: 04.07.2000
```

**Notes**
* Ensure the dates are entered in the correct format.
* The Person class includes both a default constructor and a parameterized constructor for flexibility.

**Authors**
Ayşe Nur 