using BD.Entities.Models;

namespace BD.Services;

public interface IFilmService
{
    FilmModel GetById(int id);
    FilmModel GetByIdWithCompany(int id);
    FilmModel AddFilm(FilmModel film);


}