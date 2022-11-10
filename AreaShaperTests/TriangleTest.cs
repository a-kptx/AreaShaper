using AreaShaper.Classes;
using AreaShaper.Classes.Shapes;
using AreaShaper.Extensions;

namespace AreaShaperTests;

public class TriangleTest
{
    [Fact]
    public void ZeroTest()
    {
        // Arrange
        var triangle = new Triangle(0, 0, 0);

        // Act
        var area = AreaCalculator.CalculateShapeArea(triangle);

        // Assert
        Assert.True(area.IsEqualsToZero());
        Assert.Equal(0, area, 15);
    }

    [Fact]
    public void ExceptionTest1()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(-5, 2, 2));
    }

    [Fact]
    public void ExceptionTest2()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(2, -5, 2));
    }

    [Fact]
    public void ExceptionTest3()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(2, 2, -5));
    }

    [Fact]
    public void RectangularityTest1()
    {
        // Arrange
        var triangle = new Triangle(5, 4.898979485566356, 7);

        // Act
        var isRect = triangle.IsRectangular();

        // Assert
        Assert.True(isRect);
    }

    [Fact]
    public void RectangularityTest2()
    {
        // Arrange
        var triangle = new Triangle(5.23, 4.01, 7.23);

        // Act
        var isRect = triangle.IsRectangular();

        // Assert
        Assert.False(isRect);
    }

    [Fact]
    public void IntCalculationTest()
    {
        // Arrange
        var triangle = new Triangle(5, 4, 7);

        // Act
        var area = AreaCalculator.CalculateShapeArea(triangle);

        // Assert
        Assert.Equal(9.7979589711, area, 10);
    }

    [Fact]
    public void DoubleCalculationTest()
    {
        // Arrange
        var circle = new Triangle(5.002302, 3.100230, 4.00000000231);

        // Act
        var area = AreaCalculator.CalculateShapeArea(circle);

        // Assert
        Assert.Equal(6.1987148498, area, 10);
    }
}