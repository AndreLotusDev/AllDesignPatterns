using FactoryRecorder.Classes;
using FactoryRecorder.Factory;

FactoryTheme.SetBaseTheme("AZURE");
FactoryTheme.GenerateComponent(HtmlType.HEAD);
FactoryTheme.GenerateComponent(HtmlType.HEAD);
FactoryTheme.GenerateComponent(HtmlType.BODY);
FactoryTheme.GenerateComponent(HtmlType.DIV);
FactoryTheme.GenerateComponent(HtmlType.P);
FactoryTheme.GenerateComponent(HtmlType.P);
FactoryTheme.GenerateComponent(HtmlType.DIV);
FactoryTheme.GenerateComponent(HtmlType.BODY);

FactoryTheme.SetBaseTheme("CADET");
FactoryTheme.ChangeTheme();
FactoryTheme.DoAActionThrougComponents(p => Console.WriteLine(p.DisplayHtml()));