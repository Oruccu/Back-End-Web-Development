//Task-1
Console.WriteLine("***************Task-1************************");
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın?");
Console.WriteLine(" ");

//Task-2
Console.WriteLine("***************Task-2************************");
string Word = "String bir data tuttum";
int Number = 123;

Console.WriteLine("Girmiş olduğunuz string ifade:" + Word);            // Prints the word on the console
Console.WriteLine("Girmiş olduğunuz number ifade:" + Number);          //Prints the number on the console
Console.WriteLine(" ");

//Task-3
//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Console.WriteLine("***************Task-3************************");
Random randNumber = new Random();
int NumberRand = randNumber.Next(0, 100);
Console.WriteLine(NumberRand);
Console.WriteLine(" ");

//Task-4
//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Console.WriteLine("***************Task-4************************");
Random randNumber1 = new Random();
int NumberRand1 = randNumber1.Next(0, 100);
int remainder = NumberRand1 % 3;

Console.WriteLine($"{NumberRand1} sayısının 3'e bölümünden kalan {remainder}");
Console.WriteLine(" ");

//Task-5
//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.WriteLine("***************Task-5************************");
TryData:
Console.WriteLine("Merhaba yaşınızı girer misiniz?");
string Age = Console.ReadLine();
if (int.TryParse(Age, out int userAge))
    Console.WriteLine("Yaşınız" + userAge);
else
{
    Console.WriteLine("Lütfen girdiğiniz veriyi kontrol ediniz.");
    goto TryData;
}

//Task-6
//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
Console.WriteLine("***************Task-6************************");
for (int i = 0; i < 10; i++)
    Console.WriteLine($"{i + 1} Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
Console.WriteLine(" ");

//Task-7
//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.WriteLine("***************Task-7************************");
Console.WriteLine("2 adet isim giriniz");
string name1 = Console.ReadLine();
string name2 = Console.ReadLine();

Console.WriteLine("Girmiş olduğunuz 1. isim: " + name1);
Console.WriteLine("Girmiş olduğunuz 2. isim: " + name2);
Console.WriteLine(" ");

//Task-8
//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
Console.WriteLine("***************Task-8************************");
NotReturnValue();

void NotReturnValue()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
Console.WriteLine(" ");

//Task-9
//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
Console.WriteLine("***************Task-9************************");
trySum:
Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz");
Console.WriteLine("1. sayı: ");
string num3 = Console.ReadLine();
Console.WriteLine("2. sayı: ");
string num4 = Console.ReadLine();

if (int.TryParse(num3, out int outNum3) && int.TryParse(num4, out int outNum4))
{
    int result = Sum(outNum3, outNum4);
    Console.WriteLine($"{outNum3} + {outNum4} = {result}");
}
else
{
    Console.WriteLine("Girilen sayıları kontrol ediniz");
    goto trySum;
}

int Sum(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}
Console.WriteLine(" ");

//Task-10
//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

Console.WriteLine("***************Task-10************************");
Console.WriteLine("Lütfen true ya da false değerini giriniz");
string userResult = Console.ReadLine();

string result2 = GetResponse(userResult);

Console.WriteLine(result2);

string GetResponse(string input)
{
    if (bool.TryParse(input, out bool boolValue))
    {
        if (boolValue)
        {
            return "Kullanıcı true değerini girdi.";
        }
        else
        {
            return "Kullanıcı false değerini girdi.";
        }
    }
    else
    {
        return "Geçersiz giriş. Lütfen true ya da false giriniz.";
    }
}
Console.WriteLine(" ");

//Task-11
//11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.WriteLine("***************Task-11************************");
Console.WriteLine("Lütfen yaşları giriniz");
int[] Age1 = new int[3];

int AgeRanking(int[] Age1)
{

    for (int i = 0; i < Age1.Length; i++)
    {
        Age1[i] = int.Parse(Console.ReadLine());
    }

    Array.Sort(Age1);
    int ageLenght = Age1.Length;
    int result3 = Age1[ageLenght - 1];

    return result3;
}

int enBuyukYas = AgeRanking(Age1);
Console.WriteLine("En büyük yaş: " + enBuyukYas);
Console.WriteLine(" ");

//Task-12
//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
Console.WriteLine("***************Task-12************************");

List<int> numbers = new List<int>();

Console.WriteLine("Lütfen istediğiniz kadar sayı girip, Girişi tamamlayınca 's' basınız:");

while (true)
{
    string userNumber = Console.ReadLine();
    if (userNumber.ToLower() == "s")
        break;

    if (int.TryParse(userNumber, out int number5))
        numbers.Add(number5);
    else
        Console.WriteLine("Lütfen girdiğin değeri kontrol et.");
}

int Biggest = FindTheLargestNumber(numbers);
Console.WriteLine("En büyük sayı: " + Biggest);

int FindTheLargestNumber(List<int> numbers)
{
    int Biggest = int.MinValue;
    foreach (int num in numbers)
    {
        if (num > Biggest)
            Biggest = num;
    }
    return Biggest;
}

Console.WriteLine(" ");

//Task-13
//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.WriteLine("***************Task-13************************");
Console.WriteLine("Lütfen isim giriniz:");
string FirstName = Console.ReadLine();
string SecondeName = Console.ReadLine();


Console.WriteLine("Birinci isim: " + FirstName);
Console.WriteLine("Birinci isim: " + SecondeName);

Console.WriteLine("-------------İsimleri değiştir-----------");
ChangeMethod(ref FirstName, ref SecondeName);
Console.WriteLine("Birinci isim: " + FirstName);
Console.WriteLine("Birinci isim: " + SecondeName);

void ChangeMethod(ref string FirstName, ref string SecondeName)
{
    string ChangeName;
    ChangeName = FirstName;
    FirstName = SecondeName;
    SecondeName = ChangeName;
}

Console.WriteLine(" ");
//Task-14
//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.WriteLine("***************Task-1************************");
Console.WriteLine("Lütfen sayı giriniz:");
string num5 = Console.ReadLine();
int UserNum5 = int.Parse(num5);

string result4 = DoubleOrSingle(UserNum5);
Console.WriteLine(result4);

string DoubleOrSingle(int NumberArry)
{
    string result;
    if (NumberArry % 2 == 0)
        result = "Çift bir sayı girdiniz";
    else
        result = "Tek bir sayı girdiniz";

    return result;
}
Console.WriteLine(" ");

//Task-15
//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.WriteLine("***************Task-15************************");
Console.WriteLine("Lütfen hızı giriniz:");
string Speed = Console.ReadLine();
Console.WriteLine("Lütfen time giriniz:");
string Time = Console.ReadLine();

int userSpeed = int.Parse(Speed);
int userTime = int.Parse(Time);

int road = Road(userSpeed, userTime);
Console.WriteLine("Alınan yol: " + road);

int Road(int Speed, int Time)
{
    int RoadCal = Speed * Time;
    return RoadCal;
}
Console.WriteLine(" ");

//Task-16
//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.WriteLine("***************Task-16************************");
int rad = 10;
int pi = 3;
int Circle = CircleCal(rad, pi);
Console.WriteLine("Dairenin alanı: " + Circle);

int CircleCal(int rad, int pi)
{
    int Circle = rad * rad * pi;
    return Circle;
}
Console.WriteLine(" ");

//Task-17
//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
Console.WriteLine("***************Task-17************************");
string sentence = "Zaman bir GeRi SayIm";
string UpperSentence = sentence.ToUpper();
string LowerSentence = sentence.ToLower();

Console.WriteLine("Hepsi büyük:"+ UpperSentence);
Console.WriteLine("Hepsi küçük:"+ LowerSentence);

Console.WriteLine(" ");

//Task-18
//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak
Console.WriteLine("***************Task-18************************");

string Hello = "    Selamlar   ";
string newHello = Hello.Trim();
Console.WriteLine(newHello);





