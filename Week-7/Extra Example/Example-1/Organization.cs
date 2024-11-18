using System.Collections.Generic;


public class Departman
{
    public int Id{get; set;}
    public string Name{get; set;}
}

public class Employee
{
    public int Id{get; set;}
    public string Name{get;set;}
    public int DepartmanId{get; set;}
}