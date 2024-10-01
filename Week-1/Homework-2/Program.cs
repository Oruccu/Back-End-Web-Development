Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz; ");

Console.Write("T.C: " );
double TC = double.Parse(Console.ReadLine());               
//TC requested from the user. Since an 11-digit number will be entered double variable was selected. 

Console.Write("Adi: ");
string Name = Convert.ToString(Console.ReadLine());         //Name requested from the user

Console.Write("Soyadi: ");
string Surname = Convert.ToString(Console.ReadLine());      //Surname requested from the user

Console.Write("Telefon Numarasi: ");
double Number = double.Parse(Console.ReadLine());           
//Number requested from the user. Since an 12-digit number will be entered double variable was selected. 

Console.Write("Yas: ");
int Age = int.Parse(Console.ReadLine());                    //Age requested from the user

Console.Write("İlk Aldigi Ürünün Fiyati : ");
double FirstProduct = int.Parse(Console.ReadLine());        
//First Product Price requested from the user. The double variable was chosen because of the possibility of a decimal number.

Console.Write("İkinci Aldigi Ürünün Fiyati : ");
double SecondeProduct = int.Parse(Console.ReadLine());     
//Seconde Product Price requested from the user. The double variable was chosen because of the possibility of a decimal number.

Console.WriteLine("--------------------------------------");

double Total = FirstProduct + SecondeProduct;               //Total spending
double Percent=10;              
double PatikaNumber= Total * (Percent/100);                 // Patika number:)

Console.WriteLine($"{TC} Tc numarali {Name} {Surname} isimli kisi için kayit oluşturulmuştur.");
Console.WriteLine($"{Number} telefon numarasina bildirim mesaji gönderilmiştir.");
Console.WriteLine($"{Total} toplam harcama karsiliği kazanilan %10 patika puan miktari -> {PatikaNumber} TL'dir.");


