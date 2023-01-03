namespace WithSpecialInterfaces.Classes;

public class FallsIllEvent : Event
{
    public string Address;
    
    public FallsIllEvent(string address)
    {
        Address = address;
    }
}