public abstract class Employee
{
    public string name;
    public string surname;
    public abstract void department();
    public abstract void role();
    
    
}

public class ProjectManager : Employee
{   
    public override void department()
    {
        Console.WriteLine($"Selam {name} {surname}");
        Console.WriteLine("Proje Yöneticisi olarak çalışmaktasın.");
    }
    public override void role()
    {
        
        Console.WriteLine("Sualtı projesinin süreç yönetimini yapıyorsun.");
    }
}
public class SoftwareDeveloper : Employee
{
    public override void department()
    {
        Console.WriteLine($"Selam {name} {surname}");
        Console.WriteLine("Yazılım mühendisi olarak çalışmaktasın.");
    }
    public override void role()
    {
        Console.WriteLine("Sualtı projesinin arayüz yazılımını yazıyorsun.");
    }
}


public class SalesRepresentative : Employee
{
        
    public override void department()
    {
        Console.WriteLine($"Selam {name} {surname}");
        Console.WriteLine("Satış Temsilcisi olarak çalışmaktasın.");
    }
    public override void role()
    {
        Console.WriteLine("Sualtı aracının pazarlamasını yapıyorsun.");
    }
}