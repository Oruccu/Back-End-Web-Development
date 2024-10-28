while (true)
{

    try
    {
        Console.Write("Bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş olduğunuz sayının karesi: " + number * number);
        break;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Çok büyük yada çük küçük bir sayı girdiniz" + ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Lütfen girdiğiniz değeri kontrol ediniz." + ex.Message);
    }
}