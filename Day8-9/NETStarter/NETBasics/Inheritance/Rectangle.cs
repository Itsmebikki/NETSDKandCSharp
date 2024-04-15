//Write console application to calculate the area and perimeter of 2D shapes

class Rectangle:Ishape2D
{
    //Default constructor
    public Rectangle()
    {

    }
    //Parameterized constructor
    public Rectangle(double  l, double b)
    {
        length=l;
        breadth=b;
    }
    double length;
    double breadth;

    public double GetArea()
    {
        return length * breadth;
    }

    public double GetPerimeter()
    {
        return  2 * (length + breadth);
    }
}