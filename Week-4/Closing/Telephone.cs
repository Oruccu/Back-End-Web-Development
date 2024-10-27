public class Telephone : BaseMachine
{
    public bool license { get; set; }
    public Telephone(DateTime productionDate, int serialNumber, string productionName, string description, string operatingSystem, bool license) : base(productionDate, serialNumber, productionName, description, operatingSystem)
    {
        this.license = license;
    }
    public override void PrintInfo()
    {
        if (license)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{serialNumber} numaralı {productionName} cihazın üretim tarihi : {productionDate} İşletim Sistemi ise {operatingSystem}, ürün açıklaması: {description} ürün TR lisansına sahiptir.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{serialNumber} numaralı {productionName} cihazın üretim tarihi : {productionDate} İşletim Sistemi ise {operatingSystem}, ürün açıklaması: {description} ürün TR lisansına sahip değildir.");
            Console.ResetColor();
        }
    }
    public override void ProductNameGet()
    {
        Console.WriteLine($"Ürün adı ---> {productionName}");
    }
}