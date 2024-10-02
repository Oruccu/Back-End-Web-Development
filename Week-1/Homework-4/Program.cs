int Apple = 2;
int Pear = 3;
int Strawberry = 2;
int Banana = 3;
int Other = 4;

Console.WriteLine("Rüya Manavina Hos Geldiniz!");
Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer) ");

string Choose = Console.ReadLine();
string ChooseToLower = Choose.ToLower();

//Console.WriteLine(ChooseToLower);

/*
if(ChooseToLower == "elma") 
    Console.Write($"Seçtiğiniz meyvenin fiyati: {Apple} TL");
else if (ChooseToLower == "armut")
    Console.Write($"Seçtiğiniz meyvenin fiyati: {Pear} TL");
else if (ChooseToLower == "çilek")
    Console.Write($"Seçtiğiniz meyvenin fiyati: {Strawberry} TL");
else if (ChooseToLower == "muz")
    Console.Write($"Seçtiğiniz meyvenin fiyati: {Banana} TL");
else if (ChooseToLower == "diğer")
    Console.Write($"Seçtiğiniz meyvenin fiyati: {Other} TL");
else
    Console.Write("Seçtiğiniz meyve Rüya Mavavin'da bulunmamaktadır.");

*/

switch (ChooseToLower)
{
    case "elma":
        Console.Write($"Seçtiğiniz meyvenin fiyati: {Apple} TL");
        break;
    case "armut":
        Console.Write($"Seçtiğiniz meyvenin fiyati: {Pear} TL");
        break;
    case "çilek":
        Console.Write($"Seçtiğiniz meyvenin fiyati: {Strawberry} TL");
        break;
    case "muz":
        Console.Write($"Seçtiğiniz meyvenin fiyati: {Banana} TL");
        break;
    case "diğer":
        Console.Write($"Seçtiğiniz meyvenin fiyati: {Banana} TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyve Rüya Mavavin'da bulunmamaktadır.");
        break;
}




