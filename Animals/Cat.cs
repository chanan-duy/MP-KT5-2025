namespace MP_KT5_2025;

public class Cat : IAnimal
{
    public string Name { get; set; } = "cat #1";

    public string MakeSound()
    {
        return "myau";
    }
}
