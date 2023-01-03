namespace FunctionalBuilder.FunctionalBuilder;

public class PersonInfo
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PositionInCompany { get; set; }
    public int Salary { get; set; }

    public override string ToString()
    {
        return Name + " | " + Address + "Salary: " + Salary.ToString() + " | " + PositionInCompany;
    }
}