using Autofac;
using Autofac.Features.Metadata;
using TypesOfAdapters;

var c = new ContainerBuilder();
c.RegisterType<SaveCommand>().As<ICommand>().WithMetadata("Name", "Save");
c.RegisterType<EditCommand>().As<ICommand>().WithMetadata("Name", "Edit");

c.RegisterAdapter<Meta<ICommand>, Button>(c => new Button(c.Value, (string)c.Metadata["Name"]));

c.RegisterType<Editor>();

var b = c.Build();

var editorRunning = b.Resolve<Editor>();
editorRunning.ClickInAllButtons();  
