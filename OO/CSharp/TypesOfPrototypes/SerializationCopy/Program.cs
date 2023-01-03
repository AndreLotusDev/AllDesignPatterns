using SerializationCopy.Classes;
using SerializationCopy.Helpers;

Person ownerOfTheHouse = new Person("Andre", "Soares Gomes", 22, new Address("Rua Alagoas 91", "Casa na praia"));
Console.WriteLine(ownerOfTheHouse.ToString());
Console.WriteLine("--------------------------------------");

Person sonOfTheOwnerOfThisHouse = ownerOfTheHouse.DeepCopyXml();
sonOfTheOwnerOfThisHouse.Name = "Alexsander";
sonOfTheOwnerOfThisHouse.Age = 4;

Console.WriteLine(sonOfTheOwnerOfThisHouse.ToString());
