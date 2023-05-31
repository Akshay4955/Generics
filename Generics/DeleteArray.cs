namespace Generics;

public class DeleteArray
{
    public void DeleteMethod<T>(T[] intArray, int position)
    {
        int index = position;
        for (int i = index; i < intArray.Length - 1; i++) 
        {
            intArray[i] = intArray[i + 1];
        }

        Console.WriteLine("Int array after deletion");
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        Console.WriteLine();
    }
}