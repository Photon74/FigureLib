using System.Reflection.Metadata;

namespace FigureLib;
public class Triangle : IShape
{

    double[] _sidesArr;

    /// <summary>
    /// Creates a triangle
    /// </summary>
    /// <param name="sideA">Side "A" length</param>
    /// <param name="sideB">Side "B" length</param>
    /// <param name="sideC">Side "C" length</param>
    /// <exception cref="ArgumentException"></exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0
            || sideB <= 0
            || sideC <= 0)
        {
            throw new ArgumentException("The sides of the triangle must be greater than zero!");
        }
        if (sideA + sideB < sideC
            || sideB + sideC < sideA
            || sideA + sideC < sideB)
        {
            throw new ArgumentException("The sum of the two sides cannot be less than the third!");
        }

        _sidesArr = new double[3] { sideA, sideB, sideC };
    }

    /// <summary>
    /// Returns an area of Triangle.
    /// </summary>
    public double GetArea()
    {
        double halfPerimeter = _sidesArr.Sum() / 2;

        return Math.Sqrt(halfPerimeter
            * (halfPerimeter - _sidesArr[0])
            * (halfPerimeter - _sidesArr[1])
            * (halfPerimeter - _sidesArr[2]));
    }

    /// <summary>
    /// True, if the triangle is rectangular
    /// </summary>
    public bool IsRectangular()
    {
        Array.Sort(_sidesArr);

        return Math.Pow(_sidesArr[0], 2)
        + Math.Pow(_sidesArr[1], 2)
        == Math.Pow(_sidesArr[2], 2);
    }
}
