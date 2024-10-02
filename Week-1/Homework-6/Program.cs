// 1. Konsola "Merhaba Dünya" yazdıran bir program yazın.
Console.WriteLine("Merhaba Dünya");

//2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
Console.WriteLine("İki adet sayı giriniz: ");
Console.WriteLine("Birinci sayıyı giriniz: ");
string number1 = Console.ReadLine();
Console.WriteLine("İkinci sayıyı giriniz: ");
string number2 = Console.ReadLine();
int InputNum1 = Convert.ToInt16(number1);
int InputNum2 = Convert.ToInt16(number2);

int Result = InputNum1 + InputNum2;
Console.WriteLine($"{InputNum1} + {InputNum2} = {Result}");

//3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.
Console.WriteLine("Lütfen yaşınızı giriniz: ");
string Age = Console.ReadLine();
int InputAge = Convert.ToInt16(Age);
if (InputAge > 18)
    Console.WriteLine("Yetişkinsiniz.");
else
    Console.WriteLine("Çocuksunuz.");

//4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
Console.WriteLine("Bir sayı giriniz: ");
string number = Console.ReadLine();
int InputNum = Convert.ToInt16(number);

if (InputNum % 2 == 0)
    Console.WriteLine("Girmiş olduğunuz sayı çifttir.");
else
    Console.WriteLine("Girmiş olduğunuz sayı tektir.");

//5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.
Console.WriteLine("Hava sıcaklığı nedir?");
string Temperature = Console.ReadLine();
int InputTemp = Convert.ToInt16(Temperature);
if (InputAge <= 0)
    Console.WriteLine("Donuyor");
else if (InputAge > 0 || InputAge <= 30)
    Console.WriteLine("Normal");
else if (InputAge > 30)
    Console.WriteLine("Sıcak");

//6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.
Console.WriteLine("Bir sayı giriniz: ");
string number3 = Console.ReadLine();
int InputNum3 = Convert.ToInt16(number3);

switch (InputNum3)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("1-7 arasında bir sayı girmelisiniz");
        break;
}

//7. Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)
Console.WriteLine("Notunuzu giriniz: ");
string note = Console.ReadLine();
int InputNote = Convert.ToInt16(note);

if (InputNote >= 0 || InputNote <= 60)
    Console.WriteLine("Başarısız");
else if (InputNote >= 61 || InputNote <= 80)
    Console.WriteLine("Orta");
else if (InputNote >= 81 || InputNote <= 100)
    Console.WriteLine("Başarılı");


//8. Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.

Console.WriteLine("Lütfen 1-12 arasında bir ay numarası giriniz:");
string input = Console.ReadLine();

if (int.TryParse(input, out int monthNumber) && monthNumber >= 1 && monthNumber <= 12)
{
    int daysInMonth;

    switch (monthNumber)
    {
        case 1: // Ocak
        case 3: // Mart
        case 5: // Mayıs
        case 7: // Temmuz
        case 8: // Ağustos
        case 10: // Ekim
        case 12: // Aralık
            daysInMonth = 31;
            break;

        case 4: // Nisan
        case 6: // Haziran
        case 9: // Eylül
        case 11: // Kasım
            daysInMonth = 30;
            break;

        case 2: // Şubat
            daysInMonth = 28; // Normal yıl
            break;

        default:
            daysInMonth = 0; // Bu durum asla gerçekleşmemeli
            break;
    }

    Console.WriteLine($"Seçilen ay: {monthNumber} | Gün sayısı: {daysInMonth}");
}
else
{
    Console.WriteLine("Lütfen geçerli bir ay numarası girin (1-12).");
}

//9. Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.
Console.WriteLine("Lütfen şifreyi giriniz");
string password = Console.ReadLine();
int InputPassword = Convert.ToInt16(password);

if (InputPassword == 1234)
    Console.WriteLine("Giriş başarılı.");
else
    Console.WriteLine("Giriş başarısız.");

//10. Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.
Console.WriteLine("İki adet sayı giriniz: ");

Console.WriteLine("Birinci sayıyı giriniz: ");
string number5 = Console.ReadLine();
Console.WriteLine("İkinci sayıyı giriniz: ");
string number6 = Console.ReadLine();

int InputNum5 = Convert.ToInt16(number5);
int InputNum6 = Convert.ToInt16(number6);

Console.WriteLine("Yapmak istediğiniz işlemi girin");
string? Process = Console.ReadLine();
switch (Process)
{
    case "+":
        Console.WriteLine(InputNum5 + InputNum6);
        break;
    case "-":
        Console.WriteLine(InputNum5 - InputNum6);
        break;
    case "*":
        Console.WriteLine(InputNum5 * InputNum6);
        break;
    case "/":
        Console.WriteLine(InputNum6 != 0 ? (InputNum5 / InputNum6).ToString() : "Sıfıra bölme hatası");
        break;
    default:
        Console.WriteLine("Geçersiz işlem.");
        break;
}