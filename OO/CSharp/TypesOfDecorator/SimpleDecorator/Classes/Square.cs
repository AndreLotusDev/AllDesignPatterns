namespace SimpleDecorator.Classes
{
    public class Square : Shape
    {
        public int Area { get; set; }
        public Square() : this(10)
        {
            
        }
        public Square(int area) 
        {
            Area = area;
        }
        public string AsString()
        {
            return $"This is a square with area of {Area * Area}";
        }
    }
}
