using System.Collections;

namespace SimpleIterator.Classes;

public abstract class EnumerableBase : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}