using BD.Entities;
using BD.Entities.Models;

namespace BD.DataAccess;

public interface IFilmRepo
{
    FilmEntity GetById(int id);
    FilmEntity AddFilm(FilmEntity entity);

    FilmEntity GetByIdWithCompany(int id);
}