namespace MP_KT5_2025.Shapes;

public class Triangle : IShape
{
    public double A;
    public double B;
    public double C;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double Area { get; }
    public double Perimeter => A + B + C;
}
