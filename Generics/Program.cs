namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to generics problems");
        int[] intArray = new int[] { 12, 18, 25 };
        double[] doubleArray = new double[] { 12.76, 22.76, 32.67 };
        float[] floatArray = new float[] { 13.65f, 17.53f, 11.76f };
        char[] charArray = new char[] { 'a', 'g', 'm' };
        string[] stringArray = new string[] { "Akshay", "Rahul", "Rupesh" };
        DeleteArray<int> deleteArray = new DeleteArray<int>();
        deleteArray.DeleteMethod(intArray, 1);
        DeleteArray<double> doubleDeleteArray = new DeleteArray<double>();
        doubleDeleteArray.DeleteMethod(doubleArray, 0);
        DeleteArray<char> charDeleteArray = new DeleteArray<char>();
        charDeleteArray.DeleteMethod(charArray, 2);

        MinimumArray minimumArray = new MinimumArray();
        minimumArray.FindMinimumInt(intArray);
        minimumArray.FindMinimumFloat(floatArray);
        minimumArray.FindMinimumString(stringArray);
    }
}
