//Write console application to calculate the area and perimeter of 2D shapes

class Triangle
{
    //Default constructor
    public Triangle()
    {

    }
    //Parameterized constructor
    public Triangle(double  a, double b, double c)
    {
        side1=a;
        side2=b;
        side3=c;
    }
    double side1;
    double side2;
    double side3;
    double semiperimeter;

    public double GetArea()
    {
        return √[s(s-a)(s-b)(s-c)];
    }

    public double GetPerimeter()
    {
        semiperimeter=(side1+side2+side3)/2.0;
        return  2 * semiperimeter;
    }
}