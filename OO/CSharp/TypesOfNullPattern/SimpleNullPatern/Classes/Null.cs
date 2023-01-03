using System.Dynamic;
using ImpromptuInterface;

namespace SimpleNullPatern.Classes;

public class Null<T> : DynamicObject where T : class
{
    public static T Instance
    {
        get
        {
            if (!typeof(T).IsInterface)
            {
                throw new ArgumentException("The T type should be an interface");
            }
            
            return new Null<T>().ActLike<T>();
        }
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        result = Activator.CreateInstance(binder.ReturnType);
        return true;
    }

    private class Empty
    {
        
    }
}