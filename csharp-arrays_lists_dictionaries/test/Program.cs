using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {-9, 2, 0, 8, -1, 12, -27, 3, 17, -4};

        Console.WriteLine("Element at index {0} is {1}", 2, Array.elementAt(array, 2));
        Console.WriteLine("Element at index {0} is {1}", 0, Array.elementAt(array, 0));
        Console.WriteLine("Element at index {0} is {1}", 9, Array.elementAt(array, 8));
        Array.elementAt(array, -7);
    }
}