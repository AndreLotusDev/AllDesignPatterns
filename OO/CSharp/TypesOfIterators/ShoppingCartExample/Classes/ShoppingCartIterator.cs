namespace ShoppingCartExample.Classes;

public class ShoppingCartIterator : EnumeratorBase
{
    private int _actualPosition = -1;
    private const int ZERO_POSITION = -1;

    private readonly ShoppingCart _cart;
    private readonly int _sizeList = 0;

    public ShoppingCartIterator(ShoppingCart cart)
    {
        _cart = cart;
        _sizeList = cart.GetItems().Count;
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
        _actualPosition = ZERO_POSITION;
    }

    protected override object Current()
    {
        return _cart.GetItems()[_actualPosition] as Product;
    }
}