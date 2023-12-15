using System;

public class Array
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }

        return list;
    }
}