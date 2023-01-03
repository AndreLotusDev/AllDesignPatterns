namespace SingletonNullPatern.Classes;

public interface ILog
{
    public void Warn(string message);
    public static ILog Instance { get; }
    public sealed class NullLog : ILog
    {
        private NullLog()
        {
            
        }
        
        private static Lazy<NullLog> instance => new Lazy<NullLog>(() => new NullLog());
        public static ILog Instance => instance.Value;

        public void Warn(string message)
        {
            // Do nothing
        }
    }
}