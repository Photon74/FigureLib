using Xunit;

namespace FigureLib.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(0, 0, 1)]
    [InlineData(0, 0, 0)]
    [InlineData(1, 0, 1)]
    [InlineData(1, 0, 0)]
    [InlineData(1, 1, 0)]
    public void ItShould_throw_Exeption_if_one_or_more_of_sides_less_or_equal_zero(double a, double b, double c)
    {
        // Arrange
        // Act
        //Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(5, 2, 2)]
    [InlineData(2, 5, 2)]
    [InlineData(2, 2, 5)]
    public void ItShould_throw_Exeption_if_sum_of_two_sides_less_than_third(double a, double b, double c)
    {
        // Arrange
        // Act
        //Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void ItShould_return_right_area()
    {
        // Arrange
        var sut = new Triangle(34, 12, 36);
        var expected = 203.99754900488389;

        // Act
        var actual = sut.GetArea();

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(24, 10, 26)]
    public void ItShould_return_true_if_triangle_IsRectangular(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        //Assert
        Assert.True(triangle.IsRectangular());
    }
}
