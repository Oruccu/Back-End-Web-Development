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

var queryTable = classes.GroupJoin(students,
                            classItem => classItem.ClassId,
                            student => student.ClassId,
                            (classItem, studentClasses) => new
                            {
                                ClassName = classItem.ClassName,
                                Students = studentClasses
                            });

foreach (var query in queryTable)
{
    Console.WriteLine($"Sınıf: {query.ClassName}");
    foreach (var student in query.Students)
    {
        Console.WriteLine($"  Öğrenci: {student.StudentName}");
    }
}