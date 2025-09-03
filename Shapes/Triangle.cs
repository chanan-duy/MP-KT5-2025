namespace MP_KT5_2025.Shapes;

public class Triangle : IShape
{
    public double A;
    public double B;
    public double C;

    public Triangle(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new Exception("Sides can't be negative");
        }

        if (a >= b + c)
        {
            throw new Exception("Side a must be smaller than sum of sides b and c");
        }

        if (b >= a + c)
        {
            throw new Exception("Side b must be smaller than sum of sides a and c");
        }

        if (c >= a + b)
        {
            throw new Exception("Side c must be smaller than sum of sides a and b");
        }

        A = a;
        B = b;
        C = c;
    }

    public double Area
    {
        get
        {
            var halfPerimeter = (A + B + C) / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            return area;
        }
    }

    public double Perimeter => A + B + C;
}
