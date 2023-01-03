using System.Collections;
using System.ComponentModel.Design;

namespace SimpleIterator.Classes;

public class WordsList : EnumerableBase
{
    private List<string> _words = new();
    
    private bool _isInverse = false;
    public bool IsReverse => _isInverse;

    public void SetInverseOrder()
    {
        _isInverse = !_isInverse;
    }

    public List<string> GetItems()
    {
        if (_isInverse)
        {
            return (_words as IEnumerable<string>).Reverse().ToList();
        }
        else
        {
            return _words;
        }
    }

    public void Add(string word)
    {
        _words.Add(word);
    }
    
    public override IEnumerator GetEnumerator()
    {
        return new WorldListIterator(this);
    }
}