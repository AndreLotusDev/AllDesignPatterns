namespace SimpleExample.Classes;

public class Person
{
    public string Name { get; set; }
    public ChatRoom room { get; set; }
    public Stack<string> HistoryChat { get; set; } = new();

    public Person(string name, ChatRoom room = null)
    {
        Name = name;
        this.room = room;
    }

    public void Receive(string message)
    {
        message += $" | Received by: {Name}";
        Console.WriteLine(message);
        HistoryChat.Push(message);
    }

    public void DisplayHistoryLog()
    {
        foreach (var message in HistoryChat)
        {
            Console.WriteLine(message);
        }
    }
}