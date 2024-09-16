using BD.Services;
using Microsoft.AspNetCore.Mvc;

namespace BD.Controllers;

[ApiController]
[Route("companies")]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyService _service;

    public CompaniesController(ICompanyService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetCompanyById([FromQuery] int id)
    {
        var result = _service.GetById(id);

        return Ok(result);
    }
}