using SwitchExpression.Classes;

var chest = new Chest();
chest.HaveTheKey = true;

chest.Status = ChestHandler.Manipulate(Chest.EAction.Open, chest.Status, chest.HaveTheKey);
Console.WriteLine(chest.Status.ToString());