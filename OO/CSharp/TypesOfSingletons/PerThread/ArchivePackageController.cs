public sealed class ArchivePackageController
{
    private static ThreadLocal<ArchivePackageController> threadInstance
        = new ThreadLocal<ArchivePackageController>(
            () => new ArchivePackageController());

    public int Id;
    public int NumberOfArchivesPackaged { get; set; }

    public void AddArchivesToPackage(int numberOfArchivesToPack)
    {
        NumberOfArchivesPackaged = numberOfArchivesToPack;
    }

    private ArchivePackageController()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
    }

    public static ArchivePackageController Instance => threadInstance.Value;
}