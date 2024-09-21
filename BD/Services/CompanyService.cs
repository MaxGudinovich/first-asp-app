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

    public CompanyModel AddCompany(CompanyModel company)
    {
        var entity = _mapper.Map<CompanyModel, CompanyEntity>(company);
        var addedEntity = _repo.AddCompany(entity);

        var result = _mapper.Map<CompanyEntity, CompanyModel>(addedEntity);

        return result;
    }

    public CompanyModel DeleteCompany(int id)
    {
        var entity = _repo.DeleteCompany(id);

        var result = _mapper.Map<CompanyEntity, CompanyModel>(entity);

        return result;
    }

    public CompanyModel ChangeCompany(CompanyModel company)
    {
        var entity = _mapper.Map<CompanyModel, CompanyEntity>(company);
        var changedEntity = _repo.ChangeCompany(entity);

        var result = _mapper.Map<CompanyEntity, CompanyModel>(changedEntity);

        return result;
    }
}