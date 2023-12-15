using System;
using System.Collections.Generic;

public class Array
{
    public static int MaxInteger(List<int> myList)
    {
        int i = 0;

        myList.ForEach(delegate(int item) {
        {
            
            if (item > i)
            {
                i = item;
            }

        }

        return i;
    }
}