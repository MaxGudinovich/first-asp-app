using BD.Entities;

namespace BD.DataAccess;

public interface IActorFilmRepo
{
    public void AddRange(List<ActorFilmEntity> actorFilms);
}