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
            var result = _dbSet.Include(e => e.Films).FirstOrDefault(e => e.Id == id);

            return result;
        }

        public CompanyEntity AddCompany(CompanyEntity entity)
        {
            var result = _dbSet.Add(entity);

            _context.SaveChanges();

            return result.Entity;
        }

        public CompanyEntity DeleteCompany(int id)
        {
            var entity = _dbSet.Find(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }

            return entity;
        }

        public CompanyEntity ChangeCompany(CompanyEntity entity)
        {
            var result = _dbSet.Update(entity);

            _context.SaveChanges();

            return result.Entity;
        }
    }
}