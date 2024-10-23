# Geometric Shape Area Calculator

## Description

This project demonstrates the implementation of a base geometric shape class and its derived classes (Square, Rectangle, and Triangle) in C#. The classes include properties such as `Width` and `Height`, and methods to calculate the area of each shape.

## Features

- **BaseGeometricShape Class**: Base class with `Width` and `Height` properties and a virtual `AreaCalculate()` method.
- **Square Class**: Inherits from `BaseGeometricShape` and overrides the `AreaCalculate()` method to calculate the area of a square.
- **Rectangle Class**: Inherits from `BaseGeometricShape` and overrides the `AreaCalculate()` method to calculate the area of a rectangle.
- **Triangle Class**: Inherits from `BaseGeometricShape` and overrides the `AreaCalculate()` method to calculate the area of a triangle.

## Getting Started

### Prerequisites

- .NET Framework installed on your system.

### Running the Example

1. Clone or download the repository.
2. Open the solution file in Visual Studio Code or any C# IDE.
3. Build the solution to restore any missing dependencies.
4. Run the `Program` class which contains the `Main` method.

### Code Overview

#### BaseGeometricShape Class

```csharp
public class BaseGeometricShape {
    private int _width;
    private int _height;

    public int Width {
        get => _width;
        set {
            if (value < 0) {
                Console.WriteLine("Genişlik 0'dan küçük olamaz");
            } else {
                _width = value;
            }
        }
    }

    public int Height {
        get => _height;
        set {
            if (value < 0) {
                Console.WriteLine("Yükseklik 0'dan küçük olamaz");
            } else {
                _height = value;
            }
        }
    }

    public virtual int AreaCalculate() {
        int result = _width * _height;
        return result;
    }
}
```

### Square Class

```csharp
public class Square : BaseGeometricShape {
    public override int AreaCalculate() {
        if (Width == Height)
        {
            int area = Width * Height;
            Console.WriteLine($"Karenin alanı: {area}");
            return area;
        }
        else
        {
            Console.WriteLine("Kare hesabı için yükseklik ve genişliğin aynı olması gerekmektedir");
            return -1;
        }
    }
}
```

### Main Class

```csharp
Square square = new Square();
square.Width = 10;
square.Height = 10;
square.AreaCalculate();
```

### Notes

- Ensure the width and height values are set correctly before calling the AreaCalculate() method.
- For the Square class, width and height must be equal.

### Authors

- Ayse Nur