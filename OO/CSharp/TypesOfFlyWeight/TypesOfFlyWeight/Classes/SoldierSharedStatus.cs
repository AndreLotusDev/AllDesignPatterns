using System.Drawing;

namespace TypesOfFlyWeight.Classes
{
    public class SoldierSharedStatus
    {
        public static Color Color { get; } = Color.Red;
        public static double Damage { get; } = 32;
        public static int TilesMoveCapability { get; } = 10;
    }
}
