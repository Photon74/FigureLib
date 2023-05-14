using Xunit;

namespace FigureLib.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(double.NegativeInfinity)]
    public void ItShould_throw_Exeption_when_radius_less_or_equal_zero(double radius)
    {
        // Arrange
        // Act
        //Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(0.0000000000000001)]
    [InlineData(double.PositiveInfinity)]
    public void ItShould_not_throw_Exeption_when_radius_greater_zero(double radius)
    {
        // Arrange
        // Act
        //Assert
        Assert.NotNull(() => new Circle(radius));
    }

    [Fact]
    public void ItShould_return_right_area()
    {
        // Arrange
        var expected = 3.1415926535897931;
        var sut = new Circle(1);

        // Act
        var circleArea = sut.GetArea();

        //Assert
        Assert.Equal(expected, circleArea);
    }
}