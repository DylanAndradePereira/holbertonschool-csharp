using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {98, -10, 1024, -727, -98, 0, 3200, 972, 12, 50, 8};

        Console.WriteLine("Max: " + List.MaxInteger(myList));
    }
}