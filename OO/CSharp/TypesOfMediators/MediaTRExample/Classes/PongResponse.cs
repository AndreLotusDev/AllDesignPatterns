namespace MediaTRExample.Classes;

public class PongResponse
{
    public DateTime TimeStamp { get; set; }

    public PongResponse(DateTime timeStamp)
    {
        TimeStamp = timeStamp;
    }
}