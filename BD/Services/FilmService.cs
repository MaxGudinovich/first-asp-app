using AutoMapper;
using BD.DataAccess;
using BD.Entities;
using BD.Entities.Models;

namespace BD.Services;

public class FilmService : IFilmService
{
    private readonly IFilmRepo _repo;
    private readonly IMapper _mapper;
    private readonly IActorFilmRepo _actorFilmRepo;

    public FilmService(IFilmRepo repo, IMapper mapper, IActorFilmRepo actorFilmRepo)
    {
        _repo = repo;
        _mapper = mapper;
        _actorFilmRepo = actorFilmRepo;
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

    public FilmModel AddFilmWithActors(FilmCreateModel film)
    {
        var filmEntity = new FilmEntity
        {
            Name = film.Name,
            CompanyId = film.CompanyId
        };

        var createFilm = _repo.AddFilm(filmEntity);
        var actorsFilmsEntities = new List<ActorFilmEntity>();

        foreach (var actorId in film.ActorIds)
        {
            var actorFilmEntity = new ActorFilmEntity
            {
                ActorId = actorId,
                FilmId = (int)createFilm.Id
            };

            actorsFilmsEntities.Add(actorFilmEntity);
        }

        _actorFilmRepo.AddRange(actorsFilmsEntities);

        return _mapper.Map<FilmEntity, FilmModel>(createFilm);
    }
}