using System.Collections;

namespace ShoppingCartExample.Classes;

public abstract class EnumerableBase : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}