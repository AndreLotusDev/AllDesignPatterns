namespace SimpleAdapter.Classes;

public class DateValidator
{
    public bool BeAValidDate(string value)
    {
        DateTime date;
        return DateTime.TryParse(value, out date);
    }
}