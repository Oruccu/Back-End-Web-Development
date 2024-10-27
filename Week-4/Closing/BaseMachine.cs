public abstract class BaseMachine
{
    public DateTime productionDate { get; set; }
    public int serialNumber { get; set; }
    public string productionName { get; set; }
    public string description { get; set; }
    public string operatingSystem { get; set; }

    public BaseMachine(DateTime productionDate, int serialNumber, string productionName, string description, string operatingSystem)
    {
        this.productionDate = productionDate;
        this.serialNumber = serialNumber;
        this.productionName = productionName;
        this.description = description;
        this.operatingSystem = operatingSystem;
    }

    public abstract void PrintInfo();
    public abstract void ProductNameGet();
}