using AutoMapper;
using BD.DataAccess;
using BD.Entities;
using BD.Entities.Models;

namespace BD.Services;

public class FilmService : IFilmService
{
    private readonly IFilmRepo _repo;
    private readonly IMapper _mapper;

    public FilmService(IFilmRepo repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public FilmModel GetById(int id)
    {
        var entity = _repo.GetById(id);

        var result = _mapper.Map<FilmEntity, FilmModel>(entity);

        return result;
    }

    public FilmModel GetByIdWithCompany(int id)
    {
        var entity = _repo.GetByIdWithCompany(id);

        var result = _mapper.Map<FilmEntity, FilmModel>(entity);

        return result;
    }

    public FilmModel AddFilm(FilmModel film)
    {
        var entity = _mapper.Map<FilmModel, FilmEntity>(film);
        var addedEntity = _repo.AddFilm(entity);

        var result = _mapper.Map<FilmEntity, FilmModel>(addedEntity);

        return result;
    }
}