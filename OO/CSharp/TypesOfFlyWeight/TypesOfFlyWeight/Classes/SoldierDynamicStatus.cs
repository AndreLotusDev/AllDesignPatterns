using static SimpleExample.Classes.NameGenerator;

namespace TypesOfFlyWeight.Classes
{
    public class SoldierDynamicStatus
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public SoldierDynamicStatus()
        {
            FirstName = Generate(10);
            LastName = Generate(10);    
        }

        public void GenerateNextMove()
        {
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine($"The soldier {FirstName + " " + LastName} with {SoldierSharedStatus.Color.Name} color is going to do the next move");

            var numberGenerated = new Random().Next(1, 3);

            if (numberGenerated is 1)
            {
                Console.WriteLine($"Going to hit an enemy with {SoldierSharedStatus.Damage} damage");
            }
            else if (numberGenerated is 2)
            {
                Console.WriteLine($"Walking {SoldierSharedStatus.TilesMoveCapability} tiles");
            }

            Thread.Sleep(300);
            Console.WriteLine("Finished the move");
            Console.WriteLine();
        }
    }
}
