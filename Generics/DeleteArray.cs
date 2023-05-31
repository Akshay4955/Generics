namespace Generics;

public class DeleteArray
{
    public void IntDeleteMethod(int[] intArray, int position)
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

    public void DoubleDeleteMethod(double[] doubleArray, int position)
    {
        int index = position;
        for (int i = index; i < doubleArray.Length - 1; i++)
        {
            doubleArray[i] = doubleArray[i + 1];
        }

        Console.WriteLine("double Array after deletion");
        for (int i = 0; i < doubleArray.Length - 1; i++)
        {
            Console.Write(doubleArray[i] + " ");
        }
        Console.WriteLine();
    }

    public void CharacterDeleteMethod(char[] charArray, int position)
    {
        int index = position;
        for (int i = index; i < charArray.Length - 1; i++)
        {
            charArray[i] = charArray[i + 1];
        }

        Console.WriteLine("char Array after deletion");
        for (int i = 0; i < charArray.Length - 1; i++)
        {
            Console.Write(charArray[i] + " ");
        }
    }
}