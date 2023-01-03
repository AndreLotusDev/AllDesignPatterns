using SimpleExample.Classes;

namespace SimpleExample.Factory
{
    public class VehicleFactory
    {
        private static IVehicle GenerateVehicle(Type typeOfVehicle)
        {
            var isAnVehicle = typeOfVehicle.IsAssignableTo(typeof(IVehicle));

            if(isAnVehicle is false)
            {
                throw new Exception("This is not a vehicle");
            }

            var toReturn = Activator.CreateInstance(typeOfVehicle);
            if(toReturn is null)
            {
                throw new Exception("Error while generating a new vehicle");
            }

            return toReturn as IVehicle;
        }

        public static IVehicle[] GenerateVehicles(params Type[] typeOfVehicles)
        {
            List<IVehicle> toReturn = new List<IVehicle>();

            foreach (var vehicle in typeOfVehicles)
            {
                toReturn.Add(GenerateVehicle(vehicle));
            }

            return toReturn.ToArray();
        }
    }
}
