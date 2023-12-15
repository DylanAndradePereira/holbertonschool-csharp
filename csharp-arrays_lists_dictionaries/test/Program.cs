using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        myDict.Add("a", 1);
        myDict.Add("b", 2);
        myDict.Add("c", 3);
        myDict.Add("d", 4);
        myDict.Add("e", 5);

        newDict = Dictionary.MultiplyBy2(myDict);

        foreach (KeyValuePair<string, int> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("--------------------");

        foreach (KeyValuePair<string, int> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}