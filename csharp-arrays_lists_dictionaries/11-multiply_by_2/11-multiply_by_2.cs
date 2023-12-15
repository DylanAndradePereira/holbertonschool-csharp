using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
        foreach(KeyValuePair<string, int> entry in myDict)
        {
            myDict[entry.Key] = entry.Value * 2;
        }
        
        return (myDict);
	}
}