using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace BidirectionalFields.Classes;

public class Window : INotifyPropertyChanged
{
    private string _stockValue;

    public string StockValue
    {
        get => _stockValue;
        set
        {
            if (value == _stockValue) return;
            _stockValue = value;
            OnPropertyChanged();
        }
    }

    public Window(Stock stock)
    {
        StockValue = stock.StockValue;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString()
    {
        return $"Window stock value: {_stockValue}";
    }
}