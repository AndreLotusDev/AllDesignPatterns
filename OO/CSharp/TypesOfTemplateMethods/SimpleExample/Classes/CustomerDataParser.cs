namespace SimpleExample.Classes
{
    public abstract class CustomerDataParser
    {
        protected readonly string _filePath;
        public List<CustomerData> customerDataList = new List<CustomerData>();
        
        public CustomerDataParser(string filePath, bool readAllAtSameTime = false)
        {
            _filePath = filePath;

            ParseAsync(readAllAtSameTime).Wait();
        }

        public virtual async Task ParseAsync(bool readAllAtSameTime)
        {
            var lines = await File.ReadAllLinesAsync(_filePath);
            if (readAllAtSameTime)
            {
                await HandleParseAsync(string.Join("", lines));
                return;
            }
            
            foreach (var line in lines)
            {
                await HandleParseAsync(line);
            }
        }

        private async Task HandleParseAsync(string line)
        {
            await ParseOverrideAsync(line);
        }

        public abstract Task ParseOverrideAsync(string toConsume);
    }
}
