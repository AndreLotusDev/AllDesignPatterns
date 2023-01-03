namespace SimpleExample.Classes
{
    public interface IVehicle
    {
        public int MaximumSpeed { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }

        public string ReturnVehicleInfo();
    }
}
