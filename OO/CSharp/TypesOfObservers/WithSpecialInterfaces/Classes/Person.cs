namespace WithSpecialInterfaces.Classes;

public class Person : IObservable<Event>
{
    public string Address { get; set; }
    public HashSet<PersonSubscription> subscriptions = new HashSet<PersonSubscription>();
    public IDisposable Subscribe(IObserver<Event> observer)
    {
        var personSubscription = new PersonSubscription(this, observer);
        subscriptions.Add(personSubscription);
        return personSubscription;
    }

    public void EmmitPatientCold()
    {
        foreach (var subscription in subscriptions)
        {
            subscription.Observer.OnNext(new FallsIllEvent($"{Address}"));
        }
    }
}