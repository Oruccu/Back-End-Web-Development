List<Students> students = new List<Students>(){
    new Students{StudentId=1, StudentName="Ali",ClassId =1},
    new Students{StudentId=2, StudentName="Ayşe",ClassId =2},
    new Students{StudentId=3, StudentName="Mehmet",ClassId =1},
    new Students{StudentId=4, StudentName="Fatma",ClassId =3},
    new Students{StudentId=5, StudentName="Ahmet",ClassId =2},
};

List<Classes> classes = new List<Classes>(){
    new Classes{ClassId=1, ClassName="Matematik" },
    new Classes{ClassId=2, ClassName="Türkçe" },
    new Classes{ClassId=3, ClassName="Kimya" },
};

var queryTable = students.GroupJoin(classes,
                            student => student.ClassId,
                            classItem => classItem.ClassId,
                            (student, studentClasses) => new
                            {
                                StudentName = student.StudentName,
                                Classes = studentClasses
                            });
        

foreach (var query in queryTable)
{
    Console.WriteLine($"Öğrenci: {query.StudentName}");
    foreach (var classItem in query.Classes)
    {
        Console.WriteLine($"  Sınıf: {classItem.ClassName}");
    }
}