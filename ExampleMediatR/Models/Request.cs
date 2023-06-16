using MediatR;

namespace ExampleMediatR.Models;

public class Request : IRequest<Response>
{
    public string Message { get; set; }
}