
namespace SingletonDI.Classes;

public class GameController
{
    public PointController PointController { get; set; }

    public GameController(PointController pointController)
    {
        PointController = pointController;
    }
}