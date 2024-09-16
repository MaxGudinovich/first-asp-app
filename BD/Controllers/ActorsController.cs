using BD.Services;
using Microsoft.AspNetCore.Mvc;

namespace BD.Controllers;

[ApiController]
[Route("actors")]
public class ActorsController : ControllerBase
{
    private readonly IActorService _service;

    public ActorsController(IActorService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetActorById([FromQuery] int id)
    {
        var result = _service.GetById(id);

        return Ok(result);
    }
}