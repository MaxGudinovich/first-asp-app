using AutoMapper;
using BD.DataAccess;
using BD.Entities;
using BD.Entities.Models;

namespace BD.Services;
public class CompanyService : ICompanyService
{
    private readonly ICompanyRepo _repo;
    private readonly IMapper _mapper;
    public CompanyService(ICompanyRepo repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public CompanyModel GetById(int id)
    {
        var entity = _repo.GetById(id);

        var result = _mapper.Map<CompanyEntity, CompanyModel>(entity);

        return result;
    }
}

