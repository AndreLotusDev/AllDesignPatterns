namespace SimpleExample.Classes
{
    public class CustomDataTxtParser : CustomerDataParser
    {
        private const string HEADER = "age,name,address";
        public CustomDataTxtParser(string filePath) : base(filePath, false)
        {
        }

        public override async Task ParseOverrideAsync(string toConsume)
        {
            if (toConsume == HEADER)
                return;

            var fields = toConsume.Split(',');
            var customer = new CustomerData() { age = int.Parse(fields[0]), name = fields[1], address = fields[2] };
            customerDataList.Add(customer);
        }
    }
}
