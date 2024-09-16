using BD.Entities;
using Microsoft.EntityFrameworkCore;

namespace BD.DataAccess
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly DbSet<CompanyEntity> _dbSet;
        private readonly DbContext _context;

        public CompanyRepo(DbContext context)
        {
            _dbSet = context.Set<CompanyEntity>();
            _context = context;
        }

        public CompanyEntity GetById(int id)
        {
            var result = _dbSet.Find(id);

            return result;
        }
    }
}