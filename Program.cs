namespace MP_KT5_2025;

public static class Program
{
    private static void TestAnimal(IAnimal animal)
    {
        Console.WriteLine($"{animal.Name} - {animal.MakeSound()}");
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
