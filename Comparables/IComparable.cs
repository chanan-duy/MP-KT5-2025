namespace MP_KT5_2025.Comparables;

public interface IComparable<in T>
{
    public int CompareTo(T other);
}
