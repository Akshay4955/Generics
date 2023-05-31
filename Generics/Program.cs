namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to generics problems");
        int[] intArray = new int[] {12, 18, 25 };
        double[] doubleArray = new double[] { 12.76, 22.76, 32.67 };
        char[] charArray = new char[] { 'a', 'g', 'm' };
        DeleteArray deleteArray = new DeleteArray();
        deleteArray.IntDeleteMethod(intArray, 1);
        deleteArray.DoubleDeleteMethod(doubleArray, 0);
        deleteArray.CharacterDeleteMethod(charArray, 2);
    }
}
