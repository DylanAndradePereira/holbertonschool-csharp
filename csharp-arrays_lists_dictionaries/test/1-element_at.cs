using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {

        bool alreadyExist = false;
        foreach (KeyValuePair<string, string> entry in myDict)
        {
            if (entry.Key == key)
            {
                alreadyExist = true;

                if (entry.Value != value)
                {
                    myDict[key] = value;
                }
            }
        }

        if (!alreadyExist)
        {
            myDict.Add(key,value); 
         
        }

        
            
        return (myDict);
    }
}