using MP_KT5_2025.Comparables;
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

    private static void TestComparable<T>(T obj1, T obj2) where T : Comparables.IComparable<T>
    {
        Console.WriteLine($"obj1 to obj2 = {obj1.CompareTo(obj2)}");
        Console.WriteLine($"obj2 to obj1 = {obj2.CompareTo(obj1)}");
        Console.WriteLine($"obj1 to obj1 = {obj1.CompareTo(obj1)}");
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
        var stud1 = new Student("acb", 23, 'a');
        var stud2 = new Student("bge", 24, 'b');
        Console.WriteLine("testing students");
        TestComparable(stud1, stud2);

        Console.Write(Environment.NewLine);

        var book1 = new Book("tit1", "auth1", 200);
        var book2 = new Book("tit2", "auth2", 500);
        Console.WriteLine("testing books");
        TestComparable(book1, book2);
    }

    private static void RunTests()
    {
        TestAnimals();
        Console.Write(Environment.NewLine);
        TestShapes();
        Console.Write(Environment.NewLine);
        TestComparables();
    }

    public static void Main(string[] _)
    {
        RunTests();
    }
}
