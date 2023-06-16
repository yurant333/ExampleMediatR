using ExampleMediatR.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExampleMediatR.Controllers;

public class TestController : ControllerBase
{
    private readonly IMediator _mediator;

    public TestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("/api")]
    public async Task<IActionResult> Get()
    {
        var request = new Request();
        
        Response result = await _mediator.Send(request);
        
        return Ok(result.Message);
    }
}