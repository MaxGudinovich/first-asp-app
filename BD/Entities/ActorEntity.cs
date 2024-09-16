namespace BD.Entities;

public class ActorEntity
{
    public int? Id { get; set; }

    public string Name { get; set; }

    public List<ActorFilmEntity>? ActorFilms { get; set; }
}