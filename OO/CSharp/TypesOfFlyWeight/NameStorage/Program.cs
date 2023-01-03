using NameStorage.Classes;

var nameHandler = new NamesHandler();

for (int i = 0; i < 1_000_000; i++)
{
    nameHandler.GenerateName();
}

nameHandler.ShowRepeatedNames();