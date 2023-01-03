namespace DecoratorWithDependencyInjection.Classes
{
    public class ReportWithMetrics : IReport
    {
        private readonly IReport _report;

        public ReportWithMetrics(IReport report)
        {
            _report = report;
        }
        public string GenerateReport()
        {
            return $"Wrapping with metrics... {_report.GenerateReport()}";
        }
    }
}
