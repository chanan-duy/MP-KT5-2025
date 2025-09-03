namespace MP_KT5_2025;

public class Dog : IAnimal
{
    public string Name { get; set; } = "dog #1";

    public string MakeSound()
    {
        return "gav";
    }
}
