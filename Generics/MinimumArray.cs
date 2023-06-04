namespace Generics;

public class MinimumArray
{
    public void FindMinimum(int[] intArray)
    {
        int minimum = 0;
        if (intArray[0].CompareTo(intArray[1]) < 0 && intArray[0].CompareTo(intArray[2]) < 0)
            minimum = intArray[0];
        else if (intArray[1].CompareTo(intArray[0]) < 0 && intArray[1].CompareTo(intArray[2]) < 0)
            minimum = intArray[1];
        else
            minimum = intArray[2];

        Console.WriteLine($"Minimum int number from given three integer array is : {minimum}");
    }
}
