using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index > array.Length-1)
        {
            Console.WriteLine("Index out of range");
            return -1; 
        }
        else
        {
            // return array[index]; 
            Console.WriteLine("index {0} len {1}",index , array.Length);


        }
    }
}