class Car
{
    private string _make;
    private string _model;
    private string _color;
    private int _numberofDoors;

    public string Make { get => _make; set => _make = value; }
    public string Model { get => _model; set => _model = value; }
    public string Color { get => _color; set => _color = value; }
    public int NumberofDoors
    {
        get => _numberofDoors;
        set
        {
            if (_numberofDoors == 2 || _numberofDoors == 4)
                _numberofDoors = value;

            else
            {
                Console.WriteLine("Kapı numarası 2 veya 4 olmalı");
                _numberofDoors = -1;
            }

        }
    }
    public Car(string make, string model, string color, int numberofDoors)
    {
        _make = make;
        _model = model;
        _color = color;
        _numberofDoors = numberofDoors;
    }

    public void FourDoors(){
        _numberofDoors=4;
    }
    public void TwoDoors(){
        _numberofDoors=4;
    }

    public void CarWriteConsole(){
        Console.WriteLine($"{Make} markalı {Model} model {Color} renkli arabanınız sisteme kaydedilmiştir. Arabanın kapı sayısı {NumberofDoors}. ");
    }

}