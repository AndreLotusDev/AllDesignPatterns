namespace SimpleExample.Classes
{
    public class Bike : IVehicle
    {
        public Bike()
        {
            MaximumSpeed = 35;
            Wheels = 2;
            Name = "A normal bike";
        }
        public int MaximumSpeed { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }

        public string ReturnVehicleInfo()
        {
            return $"Car vehicle: Maximum Speed = {MaximumSpeed}; Wheels = {Wheels}; Name = {Name}";
        }
    }
}
