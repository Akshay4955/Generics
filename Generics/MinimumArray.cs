namespace Generics;

public class MinimumArray
{
    public void FindMinimumInt(int[] intArray)
    {
        int minimum;
        if (intArray[0].CompareTo(intArray[1]) < 0 && intArray[0].CompareTo(intArray[2]) < 0)
            minimum = intArray[0];
        else if (intArray[1].CompareTo(intArray[0]) < 0 && intArray[1].CompareTo(intArray[2]) < 0)
            minimum = intArray[1];
        else
            minimum = intArray[2];

        Console.WriteLine($"Minimum int number from given three integer array is : {minimum}");
    }

    public void FindMinimumFloat(float[] floatArray) 
    {
        float minimum;
        if (floatArray[0].CompareTo(floatArray[1]) < 0 && floatArray[0].CompareTo(floatArray[2]) < 0)
            minimum = floatArray[0];
        else if (floatArray[1].CompareTo(floatArray[0]) < 0 && floatArray[1].CompareTo(floatArray[2]) < 0)
            minimum = floatArray[1];
        else
            minimum = floatArray[2];

        Console.WriteLine($"Minimum float number from given three float array is : {minimum}");
    }

    public void FindMinimumString(string[] stringArray)
    {
        string minimum;
        if (stringArray[0].CompareTo(stringArray[1]) < 0 && stringArray[0].CompareTo(stringArray[2]) < 0)
            minimum = stringArray[0];
        else if (stringArray[1].CompareTo(stringArray[0]) < 0 && stringArray[1].CompareTo(stringArray[2]) < 0)
            minimum = stringArray[1];
        else
            minimum = stringArray[2];

        Console.WriteLine($"Minimum float number from given three float array is : {minimum}");
    }
}
