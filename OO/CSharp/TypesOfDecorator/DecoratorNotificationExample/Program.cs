using System.Reflection;
using DecoratorNotificationExample.Classes;

Console.WriteLine("Which platforms do you want to notify?");
Console.WriteLine("1 - wpp, 2 - facebook, 3 - gmail");

var optionsChoosen = Console.ReadLine().Trim().Split(",");

var baseNotification = new NotificationConcrete();

List<DecoratorBase> decorators = new List<DecoratorBase>();

var types = Assembly.GetExecutingAssembly().GetTypes().ToList();

foreach (var asnwer in optionsChoosen)
{
    var option = (SendBy)((int.Parse(asnwer)) -1);

    if (decorators.Count == 0)
    {
        var decoratorBaseFound = types.First(f => f.Name.Trim().Contains(option.ToString())).GetConstructors()[0].Invoke(new object[] { baseNotification }) as DecoratorBase;
        decorators.Add(decoratorBaseFound);
    }
    else
    {
        var decoratorBaseFound = types.First(f => f.Name.Trim().Contains(option.ToString())).GetConstructors()[0].Invoke(new object[] { decorators.Last() }) as DecoratorBase;
        decorators.Add(decoratorBaseFound);
    }
}

Console.WriteLine(decorators.Last().Send());