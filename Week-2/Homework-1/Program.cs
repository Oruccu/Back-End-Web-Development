Console.WriteLine("****************************1. Task****************************");
for (int i = 0; i < 10; i++)
    Console.WriteLine($"{i + 1} Kendime inanıyorum, ben bu yazılım işini hallederim!");

Console.WriteLine("****************************2. Task****************************");
for (int i = 1; i <= 20; i++)
    Console.WriteLine(i);

Console.WriteLine("****************************3. Task****************************");
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
}

Console.WriteLine("****************************4. Task****************************");
int sum = 0;
for (int j = 50; j <= 150; j++)
    sum += j;
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + sum);

Console.WriteLine("****************************5. Task****************************");

int sumdoubt = 0;
int sumsingle = 0;
for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        sumdoubt += i;
    }
    else
    {
        sumsingle += i;

    }
}
Console.WriteLine("Çift sayıların toplamı: " + sumdoubt);
Console.WriteLine("Tek sayıların toplamı: " + sumsingle);

