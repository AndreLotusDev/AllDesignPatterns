namespace HouseCommands.cs.Classes
{
    public class SmartLight
    {
        public string Name { get; private set; }
        public int Intensity { get; private set; }
        public bool IsOn { get; private set; }
        public SmartLight(string name)
        {
            Name = name;
        }

        public void TurnOff()
        {
            if (IsOn is false)
            {
                throw new Exception("You can't turn off something already off");
            }
            IsOn = false;
            Console.WriteLine($"{Name} now is turned off");
        }

        public void TurnOn()
        {
            if (IsOn)
            {
                throw new Exception("You can't turn on something already on");
            }
            IsOn = true;
            Console.WriteLine($"{Name} now is turned on");
        }

        public void IncreaseIntensity(int intensity = 20)
        {
            if (Intensity + intensity <= 100)
            {
                Intensity += intensity;
            }
            Console.WriteLine($"{Name} Intensity increased to {Intensity}");
        }

        public void DecreaseIntensity(int intensity = 20)
        {
            if (Intensity - intensity >= 0)
            {
                Intensity -= intensity;
            }
            Console.WriteLine($"{Name} Intensity decreased to {Intensity}");
        }
    }
}
