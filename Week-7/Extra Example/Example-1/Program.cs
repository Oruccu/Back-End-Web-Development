
var departmans = new List<Departman>()
    {
        new Departman {Id = 1, Name = "IT"},
        new Departman {Id = 2, Name = "HR"},
    };

var employees = new List<Employee>(){
    new Employee {Id = 1, Name="Ayse", DepartmanId= 1},
    new Employee {Id = 2, Name="Şeref", DepartmanId= 2},
    new Employee {Id = 3, Name="Fatma", DepartmanId=1},
    new Employee {Id = 4, Name="Deniz", DepartmanId=2},
    new Employee {Id = 5, Name="Aleyna", DepartmanId=2},
};

// var query = from employee in employees
//             join departman in departmans
//             on employee.DepartmanId equals departman.Id into organizationGroup
//             select new
//             {
//                 employeeName = employee.Name,
//                 departmans = organizationGroup.Select(x => x.Name)
//             };

// Console.ForegroundColor = ConsoleColor.Green;
// foreach (var item in query)
// {
//     Console.WriteLine($"Çalışan:  {item.employeeName}");
//     foreach (var dept in item.departmans)
//     {
//         Console.WriteLine("Departman:  " + dept);
//     }
// }
//Console.ResetColor();

Console.WriteLine("-------------------------------------");

var query2 = departmans.GroupJoin(employees,
                                dept => dept.Id,
                                employees => employees.DepartmanId,
                                (dept, employeeGroup) => new
                                {
                                    DeptName = dept.Name,
                                    Employees = employeeGroup.OrderBy(e => e.Name),

                                }).OrderBy(x => x.DeptName);

Console.ForegroundColor = ConsoleColor.Yellow;
foreach (var item in query2)
{
    Console.WriteLine("Departman  " + item.DeptName);
    foreach (var employee in item.Employees)
    {
        Console.WriteLine("Çalışan  " + employee.Name);
    }
    Console.WriteLine("-------------------");
}
Console.ResetColor();