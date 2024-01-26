// The class
class Obj
{
    // Class Obj
    
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)   // method
    {

        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        
        return false;
        
    }

}