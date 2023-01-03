namespace SimpleBuilder.Classes;

public class EmailBuilder
{
    private readonly Email _email;

    public EmailBuilder()
    {
        _email = new Email();
    }

    public EmailBuilder AddTo(string to)
    {
        _email.To = to;

        return this;
    }

    public EmailBuilder AddFrom(string from)
    {
        _email.From = from;

        return this;
    }

    public EmailBuilder AddAttachment(string attachment)
    {
        _email.Attachment.Add(attachment);
        
        return this;
    }

    public EmailBuilder AddBody(string body)
    {
        _email.Body = body;
        
        return this;
    }

    public Email Build()
    {
        return _email;
    }
}