namespace DecoratorWithDependencyInjection.Classes
{
    internal class ReportWithLogging : IReport
    {
        private readonly IReport _report;

        public ReportWithLogging(IReport report)
        {
            _report = report;
        }
        public string GenerateReport()
        {
            return $"Logging the report... {_report.GenerateReport()}... Finishing the logging";
        }
    }
}
