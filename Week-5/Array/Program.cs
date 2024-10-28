int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Lütfen {i + 1}. değeri giriniz. ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Mevcut dizi elemanları:");
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine(" ");

int[] newarray = new int[array.Length + 1];
for (int i = 0; i < array.Length;i++){
    newarray[i] = array[i];
}

Console.WriteLine("Lütfen 11. değeri giriniz");
int newNumber = Convert.ToInt32(Console.ReadLine());
newarray[newarray.Length-1] = newNumber;

Array.Sort(newarray); //array small to large rows
Array.Reverse(newarray);

Console.WriteLine("Büyükten küçüğe sıralanmış yeni dizi elemanları:");
foreach(int i in newarray){
    Console.Write(i + " ");
}