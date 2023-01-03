using FactoryRecorder.Classes;

namespace FactoryRecorder.Factory
{
    public class FactoryTheme
    {
        private static List<BaseComponent> _componentGenerated = new List<BaseComponent>();
        private static string baseTheme = "";

        public static void DoAActionThrougComponents(Action<BaseComponent> action)
        {
            _componentGenerated.ForEach(action);
        }

        public static void ChangeTheme()
        {
            List<BaseComponent> newListToReplace = new List<BaseComponent>();
            for (int i = 0; i < _componentGenerated.Count; i++)
            {
                var c = _componentGenerated[i];
                newListToReplace.Add(GenerateComponent(c.Type, false));
            }

            _componentGenerated = newListToReplace;
        }

        public static void SetBaseTheme(string theme)
        {
            if("AZURE" == theme)
            {
                baseTheme = "AZURE";
                return;
            } 
            else if("CADET" == theme)
            {
                baseTheme = "CADET";
                return;
            }

            throw new Exception("Invalid color name");
        }

        public static BaseComponent GenerateComponent(HtmlType type, bool addToList = true)
        {
            if(baseTheme == "AZURE")
            {
                var azureThemeTemp = new AzureTheme(type);

                if(addToList)
                    _componentGenerated.Add(azureThemeTemp);

                return azureThemeTemp;
            }
            else if(baseTheme == "CADET")
            {
                var cadetComponent = new CadetBlueTheme(type);

                if (addToList)
                    _componentGenerated.Add(cadetComponent);

                return cadetComponent;
            }

            throw new Exception("Invalid color name");
        }
    }
}
