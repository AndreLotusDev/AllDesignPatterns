using MediatR;

namespace MediaTRExample.Classes;

public class PongCommandHandler : IRequestHandler<PongCommand, PongResponse>
{
    public async Task<PongResponse> Handle(PongCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Starting requisition: {DateTime.Now.ToString()}");
        await Task.Delay(request.TimeToSleep * 1_000);
        Console.WriteLine($"Finishing requisition: {DateTime.Now.ToString()}");
        return await Task.FromResult(new PongResponse(DateTime.Now));
    }
}