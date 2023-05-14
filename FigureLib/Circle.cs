namespace FigureLib;
public class Circle : IShape
{

    double _radius;

    /// <summary>
    /// Creates a circle with radius
    /// </summary>
    /// <param name="radius">Radius must be positive!</param>
    /// <exception cref="ArgumentException"></exception>
    public Circle(double radius)
    {
        if (radius <= 0) 
            throw new ArgumentException("Radius must be positive!");
        _radius = radius;
    }

    /// <summary>
    /// Returns an area of Circle
    /// </summary>
    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
