using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] newArray = new int[size];
        
        if (size == 0)
        {
            Console.WriteLine("");

            return newArray;
        }
        else if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }
        else{
            for (int i = 0; i < size; i++)
            {
                Console.Write(i);
                newArray[i] = i;
            }
            return newArray;
        }
        
    }
}