using AreaShaper.Classes;
using AreaShaper.Classes.Shapes;
using AreaShaper.Extensions;

namespace AreaShaperTests;

public class CircleTest
{
    [Fact]
    public void ZeroTest()
    {
        // Arrange
        var circle = new Circle(0);

        // Act
        var area = AreaCalculator.CalculateShapeArea(circle);

        // Assert
        Assert.True(area.IsEqualsToZero());
        Assert.Equal(0, area, 15);
    }

    [Fact]
    public void ExceptionTest()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }

    [Fact]
    public void IntCalculationTest()
    {
        // Arrange
        var circle = new Circle(5);

        // Act
        var area = AreaCalculator.CalculateShapeArea(circle);

        // Assert
        Assert.Equal(78.539816, area, 6);
    }

    [Fact]
    public void DoubleCalculationTest()
    {
        // Arrange
        var circle = new Circle(4.00000000231);

        // Act
        var area = AreaCalculator.CalculateShapeArea(circle);

        // Assert
        Assert.Equal(50.265483, area, 6);
    }
}