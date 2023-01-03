using SimpleBuilder.cs;

var htmlBuilder = new HtmlBuilder();
htmlBuilder
    .StartInitialTag("div", "")
    .StartWithChildren("ul", "")
    .AddSameLevel("li", "first li")
    .AddSameLevel("li", "second li")
    .AddSameLevel("li", "third li")
    .Father()
    .AddSameLevel("p", "tag in the end of the div")
    .AddSameLevel("div", "")
    .AddInnerChildren("div", "<p>test</p>");

Console.Write(htmlBuilder.Build());
    