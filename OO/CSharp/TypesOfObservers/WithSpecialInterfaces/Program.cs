using WithSpecialInterfaces.Classes;

public class Program : IObserver<Event>
{
    public static void Main(string[] args)
    {
        new Program();
    }
    
    public Program()
    {
        var person = new Person();
        person.Address = "Fictional Address and Street";
        
        using(person.Subscribe(this))
            person.EmmitPatientCold();
    }
    
    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(Event value)
    {
        if (value is FallsIllEvent args)
        {
            Console.WriteLine($"Doctors needs to go to address: {args.Address}");
        }
    }
}