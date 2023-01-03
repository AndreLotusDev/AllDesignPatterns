using SimpleExample.Classes;

var cr = new ChatRoom();
cr.Join(new Person("Andre Soares Gomes"));
cr.Join(new Person("Alan Soares Gomes"));

cr.Broadcast("GLOBAL ADMIN","Is there a 50% promotion in the server");

cr.Join(new Person("Joao Pereira Neves"));

Console.WriteLine("----------------------------- CLEANING CHAT LEVEL");
cr.Broadcast("GLOBAL ADMIN","Is there a 50% promotion in the server");
Console.WriteLine("----------------------------- CLEANING CHAT LEVEL");

cr.Message(cr.persons[2].Name, cr.persons[1].Name, "Hi, how are you?");