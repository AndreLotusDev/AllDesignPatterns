namespace DecoratorWithDependencyInjection.Classes
{
    public class Report : IReport
    {
        public string GenerateReport()
        {
            return $"This is a report generated";
        }
    }
}
