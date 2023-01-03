using SimpleExample.Helper;
using System.Text.Json;

namespace SimpleExample.Classes
{
    public class CustomerDataJsonParser : CustomerDataParser
    {
        public CustomerDataJsonParser(string filePath) : base(filePath, true)
        {
        }

        public override async Task ParseOverrideAsync(string toConsume)
        {
            var customerData = await JsonSerializer.DeserializeAsync<List<CustomerData>>(StringHelper.GenerateStreamFromString(toConsume));
            customerDataList.AddRange(customerData);
        }
    }
}
