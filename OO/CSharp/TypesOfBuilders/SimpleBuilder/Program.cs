using SimpleBuilder.Classes;

var builder = new EmailBuilder();

var email = builder
    .AddTo("andrsoares999@yahoo.com")
    .AddFrom("andrsoares998@yahoo.com")
    .AddAttachment("File 1")
    .AddAttachment("File 2")
    .AddAttachment("File 3")
    .AddBody(Email.LoremIpsum(10, 10, 1, 3, 3))
    .Build();
    
Console.WriteLine(email.ToString());