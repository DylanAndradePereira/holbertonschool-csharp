using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {


        if (index < 0)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        if (index < array.Length)
        {
            return array[index]; 
        }
        else
        {
            Console.WriteLine("Index out of range");
            return -1; 
            // Console.WriteLine("index {0} len {1}",index , array.Length);
        }
    }
}