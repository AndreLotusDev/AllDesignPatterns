using System.Threading.Channels;
using SingletonMonostate.cs.Classes;

var company = new CompanyInfo();
company.AnnualProfit = 1800000;
company.NumberOfEmployees = 200;

Thread.Sleep(2000);

var companyAfterOneYear = new CompanyInfo();
companyAfterOneYear.AnnualProfit = 2000000;
companyAfterOneYear.NumberOfEmployees = 220;

Console.WriteLine($"It's the same reference? {company.AnnualProfit == companyAfterOneYear.AnnualProfit && company.NumberOfEmployees == companyAfterOneYear.NumberOfEmployees}");