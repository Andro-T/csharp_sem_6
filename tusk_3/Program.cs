using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);

        PrintArrayReverse(array, index - 1);
    }
}
