using FunctionalBuilder.FunctionalBuilder;

var builder = new PersonBuilder();

var person = builder
    .WithName("Andre Soares Gomes")
    .StartAddress()
    .LivesInStreet("Fictional Street")
    .WorkAs("Developer")
    .Receives(2000)
    .Build();
    
Console.WriteLine(person.ToString());