using FigureLib;

namespace Test;

internal class Program
{
    static void Main(string[] args)
    {
        IShape c = new Circle(5);
        var area = c.GetArea();

    }
}
