namespace FactoryRecorder.Classes
{
    public abstract class BaseComponent : BaseColor
    {
        public HtmlType Type { get; }
        public BaseComponent(HtmlType type ,Color color, int alphaPercentage)
        {
            Color = color;
            AlphaPercentage = alphaPercentage;
            Type = type;
        }

        public string DisplayHtml()
        {
            return $"Color: {Color} | Alpha Percentage: {AlphaPercentage} | Type <{Type}>";
        }
    }

    public enum HtmlType
    {
        DIV,
        P,
        B,
        SECTION,
        NAV,
        HEAD,
        BODY
    }
}
