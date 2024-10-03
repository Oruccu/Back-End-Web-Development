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
int[] doubt = new int[60];
int[] single = new int[60];
int doubtIndex = 0;
int singleIndex = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
       { 
        doubt[doubtIndex] = i;
        doubtIndex++;
        }
    else
       { 
        single[singleIndex] = i;
        singleIndex++;
    }
}

Console.WriteLine("Çift sayılar: ");
foreach (int item in doubt)
{
    Console.Write(item+ " ");
}
Console.WriteLine(" ");
Console.WriteLine("Tek sayılar: ");
foreach (int item in single)
{
    Console.Write(item+ " ");
}


