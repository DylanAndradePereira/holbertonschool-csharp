using System;
using System.Collections.Generic;

public class Array
{
    public static int MaxInteger(List<int> myList)
    {
        int i = 0;

        foreach (var item in myList)
        {
            
            if (item > i)
            {
                i = item;
            }

        }

        return i;
    }
}