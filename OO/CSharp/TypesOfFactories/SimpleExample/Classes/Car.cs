namespace SimpleExample.Classes
{
    public class Car : IVehicle
    {
        public Car()
        {
            MaximumSpeed = 200;
            Wheels = 4;
            Name = "A modern car";
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
