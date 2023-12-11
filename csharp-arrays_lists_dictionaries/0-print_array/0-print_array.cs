using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] newArray;
        
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
        }
        return newArray;
    }
}