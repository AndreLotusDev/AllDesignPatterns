using MediatR;

namespace MediaTRExample.Classes;

public class PongCommand : IRequest<PongResponse>
{
    public int TimeToSleep { get; set; }
}