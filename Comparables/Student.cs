namespace MP_KT5_2025.Comparables;

public class Student : IComparable<Student>
{
    public string Name;
    public int Age;
    public char Grade;

    public Student(string name, int age, char grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public int CompareTo(Student other)
    {
        return -Grade.CompareTo(other.Grade);
    }
}
