using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (array[index] != null)
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