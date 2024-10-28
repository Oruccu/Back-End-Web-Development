List<string> Name = new List<string>();
Name.Add("Bülent Ersoy");
Name.Add("Ayşe Nur");
Name.Add("Ebru Gündeş");
Name.Add("Hadise");

Console.WriteLine("** Davetliler **");
int i = 1;
foreach (string item in Name)
{
    Console.WriteLine($"{i} - {item} ");
    i = 1 + i;
}