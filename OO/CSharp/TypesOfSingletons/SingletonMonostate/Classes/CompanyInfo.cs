namespace SingletonMonostate.cs.Classes;

public class CompanyInfo
{
    private static decimal _annualProfit;
    private static decimal _numberOfEmployees;

    public decimal AnnualProfit
    {
        get => _annualProfit; 
        set => _annualProfit = value;
    }

    public decimal NumberOfEmployees
    {
        get => _numberOfEmployees; 
        set => _numberOfEmployees = value;
    }

    public override string ToString()
    {
        return $"Company info: Profit annual: {_annualProfit} | Number Of Employees {_numberOfEmployees}";
    }
}