public class Car
{
    public DateTime ProductionDate { get; private set; }
    public string SerialNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int DoorCount { get; set; }

    public Car()
    {
        ProductionDate = DateTime.Now;

    }
}