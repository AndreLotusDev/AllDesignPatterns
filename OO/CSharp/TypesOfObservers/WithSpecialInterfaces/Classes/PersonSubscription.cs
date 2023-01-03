namespace WithSpecialInterfaces.Classes;

public class PersonSubscription : IDisposable
{
    private readonly Person _person;
    public readonly IObserver<Event> Observer;

    public PersonSubscription(Person person, IObserver<Event> observer)
    {
        _person = person;
        Observer = observer;
    }

    public void Dispose()
    {
        _person.subscriptions.Remove(this);
    }
}