using System.Text;

namespace SimpleBuilder.cs;

public class HtmlTag
{
    private string content;
    private string tag;

    private int indentationLevel = 0;

    private HtmlTag father;
    public HtmlTag GetFather() => father;
    public void SetFather(HtmlTag fatherToAdd) => father = fatherToAdd; 

    public int SetIndentLevel
    {
        set { indentationLevel = value; }
    }

    private List<HtmlTag> innerTags = new List<HtmlTag>();

    public HtmlTag GetFirstTag() => innerTags[0];

    public HtmlTag(string content, string tag, int indentationLevel = 0)
    {
        this.content = content;
        this.tag = tag;
        this.indentationLevel = indentationLevel;
    }

    public string ReadThisTag()
    {
        var sb = new StringBuilder();

        sb.AppendLine(Indent() + "<" + tag + ">");

        if (!string.IsNullOrWhiteSpace(content))
        {
            sb.AppendLine(Indent() + Indent() + content);
        }

        foreach (var innerTag in innerTags)
        {
            sb.Append(innerTag.ReadThisTag());
        }

        sb.AppendLine(Indent() + "</" + tag + ">");

        return sb.ToString();
    }
    
    private string Indent()
    {
        return "".PadLeft(this.indentationLevel);
    }

    public void AddInnerTag(HtmlTag innerTag)
    {
        if (string.IsNullOrWhiteSpace(innerTag.tag))
        {
            throw new Exception("The tag can't be empty");
        }

        innerTags.Add(innerTag);
    }

    public void IndentAllTheInnerTags()
    {
        var indentForTheInnerTags = indentationLevel + 2;
        foreach (var innerTag in innerTags)
        {
            innerTag.SetIndentLevel = indentForTheInnerTags;
            innerTag.IndentAllTheInnerTags();
        }
    }
}

