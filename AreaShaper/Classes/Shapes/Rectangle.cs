using AreaShaper.Interfaces;

namespace AreaShaper.Classes.Shapes;

public class Rectangle : IShape
{
    private readonly double _width;
    private readonly double _height;

    public Rectangle(double width, double height)
    {
        if (width < 0 || height < 0)
        {
            throw new ArgumentException("Rectangle side cannot be less than 0");
        }
        _width = width;
        _height = height;
    }

    public double CalculateArea() =>
        _width * _height;
}
