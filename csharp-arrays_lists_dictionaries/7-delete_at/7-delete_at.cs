using System;
using System.Collections.Generic;
class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {

        myList.RemoveRange(index+1, index);

        return myList;

    }

}