using BD.Entities;

namespace BD.DataAccess;

public interface ICompanyRepo
{
    CompanyEntity GetById(int id);
}