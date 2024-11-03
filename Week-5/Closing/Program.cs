List<Car> cars = new List<Car>();
string answer;

do
{
    answer = AskUser("Araba üretmek ister misiniz? (e/h)");

    if (answer.ToLower() == "h")
    {
        Console.WriteLine("Program sonlandırılıyor.");
        break;
    }
    else if (answer.ToLower() == "e")
    {
        Car newCar = new Car();

        Console.Write("Seri Numarası: ");
        newCar.SerialNumber = Console.ReadLine();

        Console.Write("Marka: ");
        newCar.Brand = Console.ReadLine();

        Console.Write("Model: ");
        newCar.Model = Console.ReadLine();

        Console.Write("Renk: ");
        newCar.Color = Console.ReadLine();

    DoorCountInput:

        Console.Write("Kapı Sayısı: ");
        if (int.TryParse(Console.ReadLine(), out int doorCount))
        {
            newCar.DoorCount = doorCount;
        }
        else
        {
            Console.WriteLine("Geçersiz kapı sayısı! Lütfen sayısal bir değer giriniz.");
            goto DoorCountInput;
        }

        cars.Add(newCar);
    }
    else
    {
        Console.WriteLine("Geçersiz cevap. Lütfen 'e' veya 'h' ile yanıtlayınız.");
    }

    answer = AskUser("Başka araba üretmek ister misiniz? (e/h)");
}
while (answer.ToLower() == "e");

Console.WriteLine("Üretilen Arabalar:");
foreach (var car in cars)
{
    Console.WriteLine($"Seri Numarası: {car.SerialNumber}, Marka: {car.Brand}");
}


static string AskUser(string question)
{
    Console.WriteLine(question);
    return Console.ReadLine();
}


