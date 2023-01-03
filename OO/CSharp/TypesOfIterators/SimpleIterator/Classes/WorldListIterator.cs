namespace SimpleIterator.Classes;

public class WorldListIterator : EnumeratorBase
{
    private int _actualPosition = -1;
    private const int INITIAL_VALUE = -1;
    private readonly int _sizeList = 0;
    private readonly WordsList _wordsList;

    public WorldListIterator(WordsList wordsList)
    {
        _wordsList = wordsList;
        _sizeList = _wordsList.GetItems().Count();
    }

    public override bool MoveNext()
    {
        var updatedPosition = _actualPosition + 1;

        if (updatedPosition < _sizeList)
        {
            _actualPosition = updatedPosition;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int Key()
    {
        return _actualPosition;
    }

    public override void Reset()
    {
        _Reset();
    }

    private void _Reset()
    {
        _actualPosition = INITIAL_VALUE;
    }

    protected override object Current()
    {
        return _wordsList.GetItems()[_actualPosition];
    }
}