using System.Dynamic;
using System.Text;
using ImpromptuInterface;

namespace LoggingProxy.Classes
{
    public class LoggingHelper<T> : DynamicObject where T : class, new()
    {
        private readonly T subject;
        private Dictionary<string, int> methodCallCount = new();

        public LoggingHelper(T subject)
        {
            this.subject = subject ?? throw new ArgumentNullException(nameof(subject));
        }

        public static I As<I>() where I : class 
        {
            if (!typeof(I).IsInterface)
            {
                throw new ArgumentException("I must be an interface type!");
            }

            return new LoggingHelper<T>(new T()).ActLike<I>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
        {
            try
            {
                Console.WriteLine($"Invoking {subject.GetType().Name}.{binder.Name} with arguments: [{string.Join("", args)}]");

                if (methodCallCount.ContainsKey(binder.Name))
                {
                    methodCallCount[binder.Name]++;
                }
                else
                {
                    methodCallCount.Add(binder.Name, 1);
                }

                result = subject.GetType().GetMethod(binder.Name).Invoke(subject, args);
                return true;
            }
            catch (Exception e)
            {
                result = null;
                return false;
            }
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var method in methodCallCount)
                {
                    sb.AppendLine($"{method.Key} called {method.Value} times!");
                }
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return Info;
        }
    }
}
