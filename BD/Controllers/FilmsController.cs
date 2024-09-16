using BD.Entities.Models;
using BD.Services;
using Microsoft.AspNetCore.Mvc;

namespace BD.Controllers;

[ApiController]
[Route("films")]
public class FilmsController : ControllerBase
{
    private readonly IFilmService _service;

    public FilmsController(IFilmService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetFilmById([FromQuery] int id)
    {
        var result = _service.GetById(id);

        return Ok(result);
    }

    [HttpGet("test")]
    public IActionResult GetFilmByIdWithCompany([FromQuery] int id)
    {
        var result = _service.GetByIdWithCompany(id);

        return Ok(result);
    }

    [HttpPost]
    public IActionResult PostNewFilm([FromBody] FilmModel film)
    {
        var result = _service.AddFilm(film);

        return Ok(result);

    }
}