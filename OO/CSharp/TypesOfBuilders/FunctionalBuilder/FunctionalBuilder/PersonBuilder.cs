namespace FunctionalBuilder.FunctionalBuilder;

public sealed class PersonBuilder
{
    public List<Action<PersonInfo>> Actions { get; set; }

    public PersonBuilder()
    {
        Actions = new List<Action<PersonInfo>>();
    }

    public PersonBuilder WithName(string nameToAdd)
    {
        Actions.Add(new Action<PersonInfo>(p => p.Name = nameToAdd));

        return this;
    }

    public PersonInfo Build()
    {
        var person = new PersonInfo();

        Actions.ForEach(f => f(person));

        return person;
    }
}

public static class PersonAddressBuilder
{
    public static PersonBuilder StartAddress(this PersonBuilder builder)
    {
        builder.Actions.Add(new Action<PersonInfo>(p => p.Address = "Address: "));

        return builder;
    }
    
    public static PersonBuilder LivesInStreet(this PersonBuilder builder ,string street)
    {
        builder.Actions.Add(new Action<PersonInfo>(p => p.Address += $"Street - {street} | "));

        return builder;
    }
}

public static class PersonJobBuilder
{
    public static PersonBuilder WorkAs(this PersonBuilder builder, string job)
    {
        builder.Actions.Add(new Action<PersonInfo>(p => p.PositionInCompany += $"JOB: {job}"));

        return builder;
    }
    
    public static PersonBuilder Receives(this PersonBuilder builder, int salary)
    {
        builder.Actions.Add(new Action<PersonInfo>(p => p.Salary = salary));

        return builder;
    }
}