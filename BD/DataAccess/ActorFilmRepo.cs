using BD.Entities;
using Microsoft.EntityFrameworkCore;

namespace BD.DataAccess;

public class ActorFilmRepo : IActorFilmRepo
{
    private readonly DbSet<ActorFilmEntity> _dbSet;
    private readonly DbContext _context;

    public ActorFilmRepo(DbContext context)
    {
        _dbSet = context.Set<ActorFilmEntity>();
        _context = context;
    }

    public void AddRange(List<ActorFilmEntity> actorFilms)
    {
        _dbSet.AddRange(actorFilms);
        _context.SaveChanges();
    }
}