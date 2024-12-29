class Program
{
    static void Main(string[] args)
    {
        // 1. Bir öğretmen nesnesi oluşturuyoruz
        IOgretmen teacher = new Teacher("Ayşe", "Nur");

        // 2. Öğretmen nesnesini ClassRoom nesnesine enjekte ediyoruz
        ClassRoom classRoom = new ClassRoom(teacher);

        // 3. Öğretmenin bilgilerini alıyoruz
        string teacherInfo = classRoom.GetTeacherInfo();

        // 4. Bilgiyi ekrana yazdırıyoruz
        Console.WriteLine(teacherInfo);
    }
}
