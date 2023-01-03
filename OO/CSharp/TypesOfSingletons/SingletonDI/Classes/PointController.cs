namespace SingletonDI.Classes;

public class PointController
{
    public int TotalPoints { get; set; }

    public void AddPoints()
    {
        TotalPoints += 1;
    }
}