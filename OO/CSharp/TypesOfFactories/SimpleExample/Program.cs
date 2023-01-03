using SimpleExample.Classes;
using SimpleExample.Factory;

var vehiclesGenerated = VehicleFactory.GenerateVehicles(typeof(Tank), typeof(Car), typeof(Bike));
vehiclesGenerated.ToList().ForEach(f => Console.WriteLine(f.ReturnVehicleInfo()));