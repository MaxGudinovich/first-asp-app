using BD.Entities.Models;
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

    [HttpPost]
    public IActionResult PostNewCompany([FromBody] CompanyModel company)
    {
        var result = _service.AddCompany(company);

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult DeleteCompany([FromQuery] int id)
    {
        var result = _service.DeleteCompany(id);

        return Ok(result);
    }

    [HttpPatch]
    public IActionResult ChangeCompany([FromBody] CompanyModel company)
    {
        var result = _service.ChangeCompany(company);

        return Ok(result);
    }
}