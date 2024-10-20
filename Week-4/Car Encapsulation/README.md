# Car Class Project

## Description

This project demonstrates the implementation of a `Car` class in C#. The class includes properties such as `Make`, `Model`, `Color`, and `NumberofDoors`. It has a parameterized constructor and methods to set the number of doors. The `CarWriteConsole` method prints the details of the car to the console.

## Features

- **Parameterized Constructor**: Initializes the properties with given values.
- **Methods `FourDoors()` and `TwoDoors()`**: Set the number of doors to 4 or 2 respectively.
- **Method `CarWriteConsole()`**: Prints the car's details to the console.

## Getting Started

### Prerequisites

- .NET Framework installed on your system.

### Running the Example

1. Clone or download the repository.
2. Open the solution file in Visual Studio Code or any C# IDE.
3. Build the solution to restore any missing dependencies.
4. Run the `Program` class which contains the `Main` method.

### Code Overview

#### Car Class

```csharp
public class Car {
    private string _make;
    private string _model;
    private string _color;
    private int _numberofDoors;

    public string Make { get => _make; set => _make = value; }
    public string Model { get => _model; set => _model = value; }
    public string Color { get => _color; set => _color = value; }
    public int NumberofDoors {
        get => _numberofDoors;
        set {
            if (value == 2 || value == 4)
                _numberofDoors = value;
            else {
                Console.WriteLine("Kapı numarası 2 veya 4 olmalı");
                _numberofDoors = -1;
            }
        }
    }

    public Car(string make, string model, string color, int numberofDoors) {
        _make = make;
        _model = model;
        _color = color;
        NumberofDoors = numberofDoors; // Property set methodunu kullanmalıyız.
    }

    public void FourDoors() {
        _numberofDoors = 4;
    }

    public void TwoDoors() {
        _numberofDoors = 2;
    }

    public void CarWriteConsole() {
        Console.WriteLine($"{Make} markalı {Model} model {Color} renkli arabanız sisteme kaydedilmiştir. Arabanın kapı sayısı {NumberofDoors}.");
    }
}
