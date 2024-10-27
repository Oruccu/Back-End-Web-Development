public class Computer : BaseMachine
{
    public int numberOfUsbInputs { get; set; }
    public bool bluetooth { get; set; }
    public Computer(DateTime productionDate, int serialNumber, string productionName, string description, string operatingSystem, int numberOfUsbInputs, bool bluetooth) : base(productionDate, serialNumber, productionName, description, operatingSystem)
    {
        this.numberOfUsbInputs = numberOfUsbInputs;
        this.bluetooth = bluetooth;
    }

    public override void PrintInfo()
    {
        if (bluetooth)
        {
            if (numberOfUsbInputs == 2 || numberOfUsbInputs == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{serialNumber} numaralı {productionName} cihazın üretim tarihi : {productionDate} İşletim Sistemi ise {operatingSystem}, ürün açıklaması: {description}. Bluettoth özelliği bulunmaktadır. USB giriş sayısı: {numberOfUsbInputs} ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Lütfen USB giriş değerinizi kontrol ediniz.");
                Console.ResetColor();
            }
        }
        else
        {
            if (numberOfUsbInputs == 2 || numberOfUsbInputs == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{serialNumber} numaralı {productionName} cihazın üretim tarihi : {productionDate} İşletim Sistemi ise {operatingSystem}, ürün açıklaması: {description}. Bluettoth özelliği bulunmamaktadır. USB giriş sayısı: {numberOfUsbInputs}.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Lütfen USB giriş değerinizi kontrol ediniz.");
                Console.ResetColor();
            }
        }
    }
    public override void ProductNameGet()
    {
        Console.WriteLine($"Ürün adı ---> {productionName}");
    }

}