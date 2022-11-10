using AreaShaper.Classes;
using AreaShaper.Classes.Shapes;
using AreaShaper.Extensions;

namespace AreaShaperTests;

public class RectangleTest
{
    [Fact]
    public void ZeroTest()
    {
        // Arrange
        var rectangle = new Rectangle(0, 0);

        // Act
        var area = AreaCalculator.CalculateShapeArea(rectangle);

        // Assert
        Assert.True(area.IsEqualsToZero());
        Assert.Equal(0, area, 15);
    }

    [Fact]
    public void ExceptionTest1()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Rectangle(-5, 2));
    }

    [Fact]
    public void ExceptionTest2()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Rectangle(2, -5));
    }

    [Fact]
    public void IntCalculationTest()
    {
        // Arrange
        var rectangle = new Rectangle(5, 4);

        // Act
        var area = AreaCalculator.CalculateShapeArea(rectangle);

        // Assert
        Assert.Equal(20, area, 10);
    }

    [Fact]
    public void DoubleCalculationTest()
    {
        // Arrange
        var rectangle = new Rectangle(5.002302, 4.00000000231);

        // Act
        var area = AreaCalculator.CalculateShapeArea(rectangle);

        // Assert
        Assert.Equal(20.0092080116, area, 10);
    }
}