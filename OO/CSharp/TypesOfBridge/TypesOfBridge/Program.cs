using System.Reflection;
using TypesOfBridge.Classes;
using TypesOfBridge.Classes.Abstract;

Console.WriteLine("Select the device");

var result = Console.ReadLine();

if(string.IsNullOrWhiteSpace(result))
{
    Console.WriteLine("Invalid option");
}

var runProject = Assembly.GetExecutingAssembly();

var foundDevice = runProject.GetTypes().Where(w => w.IsAssignableTo(typeof(MessageBase)) && w.Name.ToLower().Contains(result.ToLower().Trim())).FirstOrDefault();

if(foundDevice != null)
{
    Console.WriteLine("Choose the platform to send the message: 1 web | 2 whatsapp");
    Console.WriteLine("=======================");

    PlatformSenderBase platform;

    var platformChoosen = Console.ReadLine()?.ToLower().Trim();

    if(platformChoosen == "web")
    {
        var toSend = FormMessage();

        var message = Activator.CreateInstance(foundDevice, toSend.title, toSend.message, DateTime.Now) as MessageBase;
        platform = new WebPlatform(message);

        platform.DeliveryMessage();
    }
    else if(platformChoosen == "whatsapp")
    {
        var toSend = FormMessage();

        var message = Activator.CreateInstance(foundDevice, toSend.title, toSend.message, DateTime.Now) as MessageBase;
        platform = new WhatsappPlatform(message);

        platform.DeliveryMessage();
    }
}

(string title, string message) FormMessage()
{
    Console.WriteLine("Type the title");
    Console.WriteLine("=======================");

    var title = Console.ReadLine()?.ToLower().Trim() ?? "";

    Console.WriteLine("Type the body");
    Console.WriteLine("=======================");

    var body = Console.ReadLine()?.ToLower().Trim() ?? "";

    return new(title, body);
}