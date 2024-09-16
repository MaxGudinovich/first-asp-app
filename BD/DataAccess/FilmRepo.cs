using BD.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BD.DataAccess
{
    public class FilmRepo : IFilmRepo
    {
        private readonly DbSet<FilmEntity> _dbSet;
        private readonly DbContext _context;
        // _context.SaveChanges();

        public FilmRepo(DbContext context)
        {
            _dbSet = context.Set<FilmEntity>();
            _context = context;
        }

        public FilmEntity GetById(int id)
        {
            var result = _dbSet.Find(id);

            return result;
        }

        public FilmEntity GetByIdWithCompany(int id)
        {
            var result = _dbSet.Include(e  => e.Company).FirstOrDefault( e => e.Id == id);

            return result;
        }

        public FilmEntity AddFilm(FilmEntity film)
        {
            var result = _dbSet.Add(film);
            _context.SaveChanges();

            return result.Entity;
        }
    }
}