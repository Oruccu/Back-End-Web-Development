// Pratik - Yol Arkadaşı : Tatil uygulaması
string Location;
string InputLocation;
string Transport;
string InputTransport;
// Location Variable
int BodrumPrice = 4000;
int MarmarisPrice = 3000;
int CesmePrice = 5000;
int HotelPrice = 0;
// Transport Variable
int AirPrice = 1500;
int LandPrice = 4000;
int TransportPrice = 0;
int SumPrice = 0;
Here:
Console.WriteLine("Senin için harika tatil fırsatlarımız var!");
Console.WriteLine("Tatile gitmek istediğin yeri seçer misin: (Bodrum/Marmaris/Çeşme)");
Console.WriteLine(" ");
//Location Options
Console.WriteLine($"Bodrum (Paket başlangıç fiyatı {BodrumPrice} TL)");
Console.WriteLine($"Marmaris (Paket başlangıç fiyatı {MarmarisPrice} TL)");
Console.WriteLine($"Çeşme (Paket başlangıç fiyatı {CesmePrice} TL)");

Location = Console.ReadLine();
InputLocation = Location.ToLower();
Console.WriteLine(" ");
//The value entered by the user is checked.
if (InputLocation == "bodrum" || InputLocation == "marmaris" || InputLocation == "çeşme")
{
    //Location Price (bodrum/marmaris/cesme) 
    if (InputLocation == "bodrum")
        HotelPrice = BodrumPrice;
    else if (InputLocation == "marmaris")
        HotelPrice = MarmarisPrice;
    else if (InputLocation == "cesme")
        HotelPrice = CesmePrice;
}
else
{
    Console.WriteLine("Lütfen girdiğiniz lokasyonu kontrol ediniz!");
    goto Here;
}

HereTransport:
//Transport Options

Console.WriteLine($"{InputLocation} tatilin için heyecanlıyız. Nasıl seyehat etmek istersiniz?");
Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL))");

Transport = Console.ReadLine();
//The value entered by the user is checked.
if (Transport == "1" || Transport == "2") //
{
    InputTransport = Transport;
    //Transport Price (Land/Air) 
    if (InputTransport == "1")
        TransportPrice = LandPrice;
    else if (InputTransport == "2")
        TransportPrice = AirPrice;
}
else
{
    Console.WriteLine("Lütfen girdiğiniz ulaşım seçeneğini kontrol ediniz!");
    goto HereTransport;
}
Console.WriteLine(" ");
SumPrice = HotelPrice + TransportPrice;
Console.WriteLine("Toplam gideriniz:" + SumPrice);



