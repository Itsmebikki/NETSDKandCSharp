//Write console application to calculate the area and perimeter of 2D shapes
namespace Inheritance;
class Rectangle : IShape2D
{
    // Default parameterless constructor
    // public Rectangle()
    // {        
    // }

    // Parameterized constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    double length;
    double width;

    public double GetArea() => length * width;
    public double GetPerimeter() => 2 * (length + width);
}
