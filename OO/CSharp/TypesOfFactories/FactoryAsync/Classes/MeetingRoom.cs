namespace FactoryAsync.Classes
{
    public class GoogleMeetingRoom : CallBaseClass
    {
        public GoogleMeetingRoom(string nameOfTheRoom, int duration = 30) : base(nameOfTheRoom, duration)
        {
        }
    }
}
