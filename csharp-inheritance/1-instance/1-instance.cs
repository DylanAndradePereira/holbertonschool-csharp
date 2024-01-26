// The class
class Obj
{
    // Class Obj
    
    public static bool IsInstanceOfArray(object obj)   // method
    {

        if (obj.GetType().IsArray)
        {
            return true;
        }
        
        return false;
        
    }

}