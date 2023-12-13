using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index > array[index])
        {
            Console.WriteLine("Index out of range");
            return -1; 
        }
        else
        {
            return array[index]; 

        }
    }
}