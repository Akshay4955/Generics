namespace Generics;

public class GenMinimum<T> where T : IComparable
{
    public void FindMinimum(T[] array)
    {
        T minimum;
        if (array[0].CompareTo(array[1]) < 0 && array[0].CompareTo(array[2]) < 0)
            minimum = array[0];
        else if (array[1].CompareTo(array[0]) < 0 && array[1].CompareTo(array[2]) < 0)
            minimum = array[1];
        else
            minimum = array[2];

        Console.WriteLine($"Minimum from given array is : {minimum}");
    }
}
