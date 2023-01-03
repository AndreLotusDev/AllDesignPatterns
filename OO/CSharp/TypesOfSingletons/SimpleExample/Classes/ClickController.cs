namespace SimpleExample.Classes;

public class ClickController
{
    public int Pontuation { get; set; }
    public int GameOvers { get; set; }

    public void AddPontuation()
    {
        Console.WriteLine($"Point {Pontuation}");
        Pontuation += 1;
    }

    public void AddGameOver()
    {
        GameOvers += 1;
    }

    private static ClickController _clickController;

    public static ClickController Instance()
    {
        if (_clickController == null)
        {
            _clickController = new ClickController();

            return _clickController;
        }
        else
        {
            return _clickController;
        }
    } 
}