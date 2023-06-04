namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to generics problems");
        int[] intArray = new int[] {12, 18, 25 };
        double[] doubleArray = new double[] { 12.76, 22.76, 32.67 };
        char[] charArray = new char[] { 'a', 'g', 'm' };
        DeleteArray<int> deleteArray = new DeleteArray<int>();
        deleteArray.DeleteMethod(intArray, 1);
        DeleteArray<double> doubleDeleteArray = new DeleteArray<double>();
        doubleDeleteArray.DeleteMethod(doubleArray, 0);
        DeleteArray<char> charDeleteArray = new DeleteArray<char>();
        charDeleteArray.DeleteMethod(charArray, 2);

        MinimumArray minimumArray = new MinimumArray();
        minimumArray.FindMinimum(intArray);
    }
}
