using SimpleAdapter.Classes;

namespace SimpleAdapter.Interfaces;

public interface IValidator
{
    public bool IsAValidEmail(string address);
    public bool IsAValidDate(string date);
}

public class Validator : IValidator
{
    private EmailValidator _emailValidator = new EmailValidator();
    private DateValidator _dateValidator = new DateValidator();
    
    public Validator()
    {
            
    }
    
    public bool IsAValidEmail(string address)
    {
        return _emailValidator.IsValidEmail(address);
    }

    public bool IsAValidDate(string date)
    {
        return _dateValidator.BeAValidDate(date);
    }
}

