using MP_KT5_2025.Shapes;

namespace MP_KT5_2025;

public static class Program
{
    private static void TestAnimal(IAnimal animal)
    {
        Console.WriteLine($"{animal.Name} - {animal.MakeSound()}");
    }

    private static void TestShape(IShape shape)
    {
        Console.WriteLine($"area: {shape.Area:F4}\tperimeter: {shape.Perimeter:F4}");
    }

    private static void TestAnimals()
    {
        var dog = new Dog();
        var cat = new Cat();

        TestAnimal(dog);
        TestAnimal(cat);
    }

    private static void TestShapes()
    {
        var circle = new Circle(5);
        Console.WriteLine("circle");
        TestShape(circle);

        var rectangle = new Rectangle(10, 20);
        Console.WriteLine("rectangle");
        TestShape(rectangle);

        var triangle = new Triangle(2, 4, 5);
        Console.WriteLine("triangle");
        TestShape(triangle);
    }

    private static void TestComparables()
    {
    }

    private static void RunTests()
    {
        TestAnimals();
        TestShapes();
        TestComparables();
    }

    public static void Main(string[] _)
    {
        RunTests();
    }
}
