namespace Generics;

public class DeleteArray<T>
{
    public void DeleteMethod(T[] intArray, int position)
    {
        Console.WriteLine("Array before delete operation");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        Console.WriteLine();
        int index = position;
        for (int i = index; i < intArray.Length - 1; i++) 
        {
            intArray[i] = intArray[i + 1];
        }

        Console.WriteLine("array after deletion");
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        Console.WriteLine();
    }
}