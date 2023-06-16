using MediatR;

namespace ExampleMediatR.Models;

public class Handler : IRequestHandler<Request, Response>
{
    public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
    {
        return new Response { Message = "Hello, Leonid Tuz!" };
    }
}