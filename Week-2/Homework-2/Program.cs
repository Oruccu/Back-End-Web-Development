/*
Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.

1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
*/
Console.WriteLine("****************************1. Task****************************");
int control1 = 0;
while (control1 <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    control1++;
}

Console.WriteLine("****************************2. Task****************************");
int control2 = 0;
while (control2 <= 20)
{
    Console.Write(control2 + " ");
    control2++;
}
Console.WriteLine(" "); //Moves to the next line

Console.WriteLine("****************************3. Task****************************");
int control3 = 0;
while (control3 <= 20)
{
    if (control3 % 2 == 0)
    {
        Console.Write(control3 + " ");
    }
    control3++;
}
Console.WriteLine(" "); //Moves to the next line

Console.WriteLine("****************************4. Task****************************");
int control4 = 50;
int sumResult = 0;
while (control4 <= 150)
{
    sumResult += control4;
    control4++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamını: " + sumResult);

Console.WriteLine("****************************5. Task****************************");
int startnumber = 0;
int sumdoubt = 0;
int sumsingle = 0;

while (startnumber < 120)
{
    if (startnumber % 2 == 0)
        sumdoubt += startnumber;
    else
        sumsingle += startnumber;
    
    startnumber++;
}

Console.WriteLine("Tek sayıların toplamı: " + sumsingle);
Console.WriteLine("Çift sayıların toplamı: " + sumdoubt);
