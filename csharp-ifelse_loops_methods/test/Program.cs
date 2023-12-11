using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0 ; i < 89 ; i++)
        {
            Console.Write("{0}, ",i);
            if (i != 57)
            {
                Console.Write(", ");
            }
        }
    }
}