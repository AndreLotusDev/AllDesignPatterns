using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace BidirectionalFields.Classes;

public class Stock : INotifyPropertyChanged
{
    private string _stockValue;
    public string StockName { get; set; }

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

    public Stock(string stockName, string stockValue)
    {
        StockName = stockName;
        StockValue = stockValue;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    
    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged(
        [CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, 
            new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString()
    {
        return $"Stock {StockName} with Price {StockValue}";
    }
}