using System;
using System.Collections.Generic;

class List
{
    public static void DeleteAt(List<int> myList, int index)
    {
        if (index >= myList.Count | index < 0)
        {
            Console.WriteLine("Index is out of range");
        }
        else
        {
            myList.Remove(myList[index]);
        }
    }
}