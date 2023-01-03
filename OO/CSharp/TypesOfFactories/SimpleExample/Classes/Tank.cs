namespace SimpleExample.Classes
{
    public class Tank : IVehicle
    {
        public Tank()
        {
            MaximumSpeed = 80;
            Wheels = 6;
            Name = "Old fashioned tank";
        }

        public int MaximumSpeed { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }

        public string ReturnVehicleInfo()
        {
            return $"Tank Vehicle: Maximum Speed = {MaximumSpeed}; Wheels = {Wheels}; Name = {Name}";
        }
    }
}
