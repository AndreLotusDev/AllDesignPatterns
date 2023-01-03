namespace SimpleBuilder.cs;

public class HtmlBuilder
{
    private HtmlTag initialTag;
    private HtmlTag actualInnerTag;
    private HtmlTag lastTag;

    public HtmlTag Tag
    {
        get { return initialTag; }
    }

    public HtmlBuilder StartInitialTag(string tag, string content)
    {
        initialTag = new HtmlTag(content, tag);

        lastTag = initialTag;
        return this;
    }

    public HtmlBuilder StartWithChildren(string tag, string content)
    {
        var tagToAdd = new HtmlTag(content, tag);
        
        tagToAdd.SetFather(initialTag);
        initialTag.AddInnerTag(tagToAdd);

        actualInnerTag = tagToAdd;
        lastTag = tagToAdd;
        return this;
    }

    public HtmlBuilder AddInnerChildren(string tag, string content)
    {
        var tagToAdd = new HtmlTag(content, tag);
        if (actualInnerTag is null)
        {
            initialTag.GetFirstTag().AddInnerTag(tagToAdd);
            
        
            actualInnerTag = tagToAdd;
            tagToAdd.SetFather(actualInnerTag);
        }
        else
        {
            actualInnerTag.AddInnerTag(tagToAdd);
            tagToAdd.SetFather(actualInnerTag);

            actualInnerTag = tagToAdd;
        }

        lastTag = tagToAdd;
        return this;
    }

    public HtmlBuilder AddSameLevel(string tag, string content)
    {
        var tagToAdd = new HtmlTag(content, tag);
        
        actualInnerTag.AddInnerTag(tagToAdd);
        tagToAdd.SetFather(actualInnerTag);

        lastTag = tagToAdd;
        return this;
    }

    public HtmlBuilder GetLastTagAdded(string tag, string content)
    {
        actualInnerTag = lastTag;
        
        return this;
    }

    public HtmlBuilder Father()
    {
        actualInnerTag = actualInnerTag.GetFather();
        return this;
    }

    public string Build()
    {
        initialTag.IndentAllTheInnerTags();
        return initialTag.ReadThisTag();
    }
}