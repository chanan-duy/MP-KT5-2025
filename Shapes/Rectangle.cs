namespace MP_KT5_2025.Shapes;

public class Rectangle : IShape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        if (width < 0)
        {
            throw new Exception("Width can't be negative");
        }

        if (height < 0)
        {
            throw new Exception("Height can't be negative");
        }

        Width = width;
        Height = height;
    }

    public double Area => Width * Height;
    public double Perimeter => 2 * (Width + Height);
}
