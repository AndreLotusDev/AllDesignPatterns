using System.ComponentModel;
using System.Runtime.CompilerServices;
using TypesOfObservers.Annotations;

namespace TypesOfObservers.Classes;

public class Person
{
    private string _email;
    public string Name { get; set; }
    public string FullName { get; set; }

    public string Email
    {
        get => _email;
        set
        {
            OnPropertyChanged(value);
            _email = value;
        }
    }

    public string Phone { get; set; }

    public Person()
    {
    }

    public Person(string name, string fullName, string email, string phone)
    {
        Name = name;
        FullName = fullName;
        Email = email;
        Phone = phone;
    }
    
    public event EventHandler<PersonChangedEventArgs> PersonChanged;

    protected virtual void OnPropertyChanged(string newValue, [CallerMemberName] string? propertyName = null)
    {
        PersonChanged?.Invoke(this, new PersonChangedEventArgs(
            propertyName, 
            this.GetType().GetProperty(propertyName).GetValue(this).ToString(),
            newValue = newValue
        ));
    }
}

public class PersonFactory
{
    public static Person CreatePerson(string name, string fullName, string email, string phone)
    {
        var person = new Person(name, fullName, email, phone);

        person.PersonChanged += SendToSystemTheChangingFields;
        person.PersonChanged += SendSmsToUSerTheChangingFields;

        return person;
    }
    
    static void SendToSystemTheChangingFields(object sender, PersonChangedEventArgs args)
    {
        var messageToPrepare = "This person has been changed " + (sender as Person).FullName + " " + args.ToString();
        Console.WriteLine("Sending by system... " + messageToPrepare);
    }

    static void SendSmsToUSerTheChangingFields(object sender, PersonChangedEventArgs args)
    {
        var messageToPrepare = "This person has been changed " + (sender as Person).FullName + " " + args.ToString();
        Console.WriteLine("Sending by SMS to the user... " + messageToPrepare);
    }

}

public class PersonChangedEventArgs
{
    public PersonChangedEventArgs(string field, string oldValue, string newValue)
    {
        Field = field;
        OldValue = oldValue;
        NewValue = newValue;
    }

    public override string ToString()
    {
        return $"Field: {Field}, Old Value: {OldValue}, New Value: {NewValue}";
    }

    public string Field { get; }
    public string OldValue { get; }
    public string NewValue { get; }
}