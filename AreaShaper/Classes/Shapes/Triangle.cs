using AreaShaper.Extensions;
using AreaShaper.Interfaces;

namespace AreaShaper.Classes.Shapes;

public class Triangle : IShape
{
    private readonly double _firstEdge;
    private readonly double _secondEdge;
    private readonly double _thirdEdge;

    public Triangle(double firstEdge, double secondEdge, double thirdEdge)
    {
        if (firstEdge < 0 || secondEdge < 0 || thirdEdge < 0)
        {
            throw new ArgumentException("Triangle edge cannot be less than 0");
        }
        _firstEdge = firstEdge;
        _secondEdge = secondEdge;
        _thirdEdge = thirdEdge;
    }

    public bool IsRectangular()
    {
        var result = false;
        if (_firstEdge > _secondEdge && _firstEdge > _thirdEdge)
        {
            var checkDiff = Math.Pow(_firstEdge, 2) - (Math.Pow(_secondEdge, 2) + Math.Pow(_thirdEdge, 2));
            if (checkDiff.IsEqualsToZero())
            {
                result = true;
            }
        }
        else if (_secondEdge > _firstEdge && _secondEdge > _thirdEdge)
        {
            var checkDiff = Math.Pow(_secondEdge, 2) - (Math.Pow(_firstEdge, 2) + Math.Pow(_thirdEdge, 2));
            if (checkDiff.IsEqualsToZero())
            {
                result = true;
            }
        }
        else if (_thirdEdge > _firstEdge && _thirdEdge > _secondEdge)
        {
            var checkDiff = Math.Pow(_thirdEdge, 2) - (Math.Pow(_firstEdge, 2) + Math.Pow(_secondEdge, 2));
            if (checkDiff.IsEqualsToZero())
            {
                result = true;
            }
        }
        return result;
    }

    public double CalculatePerimeter() =>
        _firstEdge + _secondEdge + _thirdEdge;

    public double CalculateArea()
    {
        var p = CalculatePerimeter() / 2.0;
        return Math.Sqrt(p * (p - _firstEdge) * (p - _secondEdge) * (p - _thirdEdge));
    }
}
