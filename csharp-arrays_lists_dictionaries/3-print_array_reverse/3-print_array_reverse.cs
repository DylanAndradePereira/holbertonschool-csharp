using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
           for (int i = array.Length-1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}",array[i]);
        
                }else
                {
                    Console.Write("{0} ",array[i]);
                    
                }

            }  
        }else
        {
            Console.WriteLine("");
        }
          
        if (array == null)
        {
            Console.WriteLine("");
        }
    }
}