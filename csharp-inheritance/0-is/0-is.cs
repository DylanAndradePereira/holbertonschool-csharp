// The class
class Obj
{
    // Class Obj
    
    public static bool IsOfTypeInt(object obj)   // method
    {

        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        
        return false;
        
    }

}