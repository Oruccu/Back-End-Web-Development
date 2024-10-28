List<string> Coffee = new List<string>();
for (int i = 0;i < 5; i++){
    Console.Write($"Kahve {i+1}. ");
    Coffee.Add(Console.ReadLine());
}

Console.WriteLine("Girilen Kahve İsimleri");
foreach (var item in Coffee)
{
    Console.WriteLine(item);
}