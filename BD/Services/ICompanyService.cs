using BD.Entities.Models;

namespace BD.Services;
public interface ICompanyService
{
    CompanyModel GetById(int id);
}

