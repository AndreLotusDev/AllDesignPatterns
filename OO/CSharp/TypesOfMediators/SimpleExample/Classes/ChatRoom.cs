namespace SimpleExample.Classes;

public class ChatRoom
{
    public List<Person> persons { get; set; } = new();

    public ChatRoom(List<Person> persons = null)
    {
        persons = persons ?? new List<Person>();
    }

    public void Join(Person newPersonToJoin)
    {
        persons.Add(newPersonToJoin);
        newPersonToJoin.room = this;
        
        Broadcast(newPersonToJoin.Name, "Has joined to the chat room!");
    }

    public void Broadcast(string source, string message)
    {
        persons
            .Where(f => f.Name != source)
            .ToList()
            .ForEach(f => f?.Receive(GeneratePlaceHolder(source, message)));
    }

    private string GeneratePlaceHolder(string source, string message) =>
        $"{source} send: {message} | {DateTime.Now.ToShortTimeString()}";

    public void Message(string source, string to, string message)
    {
        persons.FirstOrDefault(f => f.Name.ToLower().Contains(to.ToLower()))?
            .Receive(GeneratePlaceHolder(source, message));
    }
}