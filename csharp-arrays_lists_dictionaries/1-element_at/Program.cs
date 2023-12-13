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

int[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);