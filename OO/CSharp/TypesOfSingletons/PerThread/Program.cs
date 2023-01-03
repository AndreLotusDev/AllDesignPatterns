

var packagerOne = Task.Factory.StartNew(() =>
{
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"package one ID: " + ArchivePackageController.Instance.Id);
    ArchivePackageController.Instance.AddArchivesToPackage(10);
    Console.WriteLine($"package one: " +ArchivePackageController.Instance.NumberOfArchivesPackaged);
    Console.WriteLine("----------------------------------------------");
});

var packagerTwo = Task.Factory.StartNew(() =>
{
    Thread.Sleep(100);
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"package two ID: " + ArchivePackageController.Instance.Id);
    ArchivePackageController.Instance.AddArchivesToPackage(25);
    Console.WriteLine($"package two: " + ArchivePackageController.Instance.NumberOfArchivesPackaged);
    Console.WriteLine("----------------------------------------------");
});

var packageThree = Task.Factory.StartNew(() =>
{
    Thread.Sleep(250);
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"package three ID: " + ArchivePackageController.Instance.Id);
    ArchivePackageController.Instance.AddArchivesToPackage(35);
    Console.WriteLine($"package three: " + ArchivePackageController.Instance.NumberOfArchivesPackaged);
    Console.WriteLine("----------------------------------------------");
});

Thread.Sleep(3000);
Console.WriteLine("Finishing the program");