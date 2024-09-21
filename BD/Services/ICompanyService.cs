using BD.Entities.Models;

namespace BD.Services;

public interface ICompanyService
{
    CompanyModel GetById(int id);

    CompanyModel AddCompany(CompanyModel company);

    CompanyModel DeleteCompany(int id);

    CompanyModel ChangeCompany(CompanyModel company);
}