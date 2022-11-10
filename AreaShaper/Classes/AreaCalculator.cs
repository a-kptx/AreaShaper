using AreaShaper.Interfaces;

namespace AreaShaper.Classes;

public static class AreaCalculator
{
    public static double CalculateShapeArea<T>(T shape)
        where T : IShape =>
            shape.CalculateArea();
}
