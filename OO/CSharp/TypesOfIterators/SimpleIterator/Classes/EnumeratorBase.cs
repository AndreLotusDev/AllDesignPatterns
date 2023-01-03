﻿using System.Collections;

namespace SimpleIterator.Classes;

public abstract class EnumeratorBase : IEnumerator
{
    public abstract bool MoveNext();

    public abstract void Reset();

    protected abstract object Current();

    public abstract int Key();

    object IEnumerator.Current => Current();
}