namespace FactoryAsync.Classes
{
    public class CallBaseClass
    {
        public Guid Id { get; set; }
        public string NameOfTheRoom { get; set; } = "";
        public int Duration { get; set; }

        public CallBaseClass(string nameOfTheRoom, int duration = 30)
        {
            Id = Guid.NewGuid();
            NameOfTheRoom = nameOfTheRoom;
            Duration = duration;

            Console.WriteLine("Meeting starting....");
        }
    }
}
