// The class
using System.Diagnostics;
class Obj
{
    // Class Obj
    
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)   // method
    {
        return derivedType.IsSubclassOf(baseType);
        
    }

}