namespace ProtectionProxy.Classes
{
    public class Files
    {
        public List<string> FilesNames { get; } = new() { "credentials.pwd", "passwords.pwd.txt" };
    }

    public class FilesProxy
    {
        private readonly Files files = new Files();
        public FilesProxy(string password)
        {
            if (password != "Administrator")
            {
                throw new Exception("You cannt access the file system");
            }
        }

        public string GetFileNames() => string.Join(" | ", files.FilesNames.Select(s => s));
    }
}
