using System;

namespace Company.ClassLibrary1;

public interface IOgretmen
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string GetInfo();
}
