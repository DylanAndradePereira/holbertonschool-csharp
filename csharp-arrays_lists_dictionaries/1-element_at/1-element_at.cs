using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (array[index])
        {
            return array[index];  
        }
        else
        {
            Console.WriteLine("Index out of range")
            return -1;
        }
    }
}