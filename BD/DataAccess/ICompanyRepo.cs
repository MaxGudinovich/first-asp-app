using BD.Entities;

namespace BD.DataAccess;

public interface ICompanyRepo
{
    CompanyEntity GetById(int id);

    CompanyEntity AddCompany(CompanyEntity entity);

    CompanyEntity DeleteCompany(int id);

    CompanyEntity ChangeCompany(CompanyEntity entity);
}