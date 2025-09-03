namespace MP_KT5_2025.Comparables;

public class Book : IComparable<Book>
{
    public string Title;
    public string Author;
    public double Price;

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public int CompareTo(Book other)
    {
        return Price.CompareTo(other.Price);
    }
}
