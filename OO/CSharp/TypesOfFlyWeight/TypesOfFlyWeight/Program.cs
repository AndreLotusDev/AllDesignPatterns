using TypesOfFlyWeight.Classes;

List<SoldierDynamicStatus> soldiers = new List<SoldierDynamicStatus>();

for (int i = 0; i < 1000; i++)
{
    soldiers.Add(new SoldierDynamicStatus());
}

for (int i = 0; i < 10; i++)
{
    foreach (var soldier in soldiers)
    {
        soldier.GenerateNextMove();
    }
}