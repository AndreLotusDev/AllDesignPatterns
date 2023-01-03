using Autofac;
using DecoratorWithDependencyInjection.Classes;

var containerService = new ContainerBuilder();

containerService.RegisterType<Report>().Named<IReport>("default_reporting");
containerService.RegisterDecorator<IReport>((c,s) => new ReportWithLogging(s), "default_reporting", "default_reporting_with_logging");
containerService.RegisterDecorator<IReport>((c,s) => new ReportWithMetrics(s), "default_reporting_with_logging", "metrics_reporting");

var runtimeContainer = containerService.Build();
var reportWithMetrics = runtimeContainer.ResolveNamed<IReport>("metrics_reporting");

Console.WriteLine(reportWithMetrics.GenerateReport());

