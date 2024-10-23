public class BaseGeometricShape
{
    private int _width;
    private int _height;
    public int Width
    {
        get => _width;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Genişlik 0'dan küçük olamaz");
            }
            else
            {
                _width = value;
            }
        }
    }
    public int Height
    {
        get => _height;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Yükseklik 0'dan küçük olamaz");
            }
            else
            {
                _height = value;
            }
        }
    }
    public virtual int AreaCalculate()
    {
        int result = _width * _height;
        return result;
    }
}
public class Square : BaseGeometricShape
{
    public override int AreaCalculate()
    {
        if (Width == Height)
        {
            int area = Width * Height;
            Console.WriteLine($"Karenin alanı: {area}");
            return area;
        }
        else
        {
            Console.WriteLine("Kare hesabı için yükseklik ve genişliğin aynı olması gerekmektedir");
            return -1;
        }
    }
}
public class Rectangle : BaseGeometricShape
{
    public override int AreaCalculate()
    {
        int area = Width * Height;
        Console.WriteLine($"Dikdörtgen alanı: {area}");
        return area;
    }

}
public class Triangle : BaseGeometricShape
{
    public override int AreaCalculate()
    {
        int area = (Width * Height) / 2;
        Console.WriteLine($"Diküçgen alanı: {area}");
        return area;
    }
}