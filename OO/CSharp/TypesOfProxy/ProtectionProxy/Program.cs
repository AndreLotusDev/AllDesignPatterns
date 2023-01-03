using ProtectionProxy.Classes;

var fileAccess = new FilesProxy("Administrator");
Console.WriteLine(fileAccess.GetFileNames());