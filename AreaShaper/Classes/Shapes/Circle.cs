using AreaShaper.Interfaces;

namespace AreaShaper.Classes.Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle radius cannot be less than 0", nameof(radius));
        }
        _radius = radius;
    }

    public double CalculateArea() =>
        Math.PI * Math.Pow(_radius, 2);
}
