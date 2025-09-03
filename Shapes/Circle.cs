namespace MP_KT5_2025.Shapes;

public class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area => Math.Pow(Radius, 2) * Math.PI;
    public double Perimeter => 2 * Radius * Math.PI;
}
