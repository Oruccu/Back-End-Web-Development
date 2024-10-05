/*
Pratik - İlk Metot Uygulamamız
Aynı uygulama içerisinde 4 adet metot tanımlamanız ve çağırmanız isteniyor :

1) Geriye Değer Döndürmeyen Bir void metot.

 - Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

2) Geriye Tamsayı Döndüren Bir metot

 - Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

3) Parametre Alan ve Geriye Değer Döndüren Bir Metot

 - Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

4) Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

    - Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
*/
//1. Task
BestSong();

static void BestSong()
{
    Console.WriteLine("It was you when we first met eyes");
    Console.WriteLine("It was you in the city lights");
    Console.WriteLine("It was you when I almost lost control");
    Console.WriteLine("It was you through the darkest times");
    Console.WriteLine("It was you that would make me shine");
    Console.WriteLine("It was you that I hold on tight");
    Console.WriteLine("It's always been you");
    Console.WriteLine("----------------------------------------");
}

Console.WriteLine(" ");
//2. Task

string result = RandomSum();
Console.WriteLine(result);
string RandomSum()
{
    Random num1 = new Random();
    int numRand = num1.Next();

    string result;
    if (numRand % 2 == 0)
        result = $"{numRand} 2'ye bölümünden kalan 0'dır";
    else
        result = $"{numRand} 2'ye bölümünden kalan 1'dır";

    return result;
}
Console.WriteLine(" ");
Console.WriteLine("----------------------------------------");

//3. Task
Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz");

string num2 = Console.ReadLine();
string num3 = Console.ReadLine();

int usernum2 = int.Parse(num2);
int usernum3 = int.Parse(num3);

int sumResult = Sum(usernum2, usernum2);

Console.WriteLine($"{usernum2} + {usernum3} = {sumResult}");

int Sum(int a, int b)
{
    return a + b;
}

//4. Task
Console.WriteLine("Lütfen adınızı ve soyadınızı giriniz");
string name = Console.ReadLine();
string surname = Console.ReadLine();

string user = UserData(name, surname);

Console.WriteLine(user);

string UserData (string n , string s){
    string result = $"Hoş Geldiniz {n} {s}";
    return  result;
}