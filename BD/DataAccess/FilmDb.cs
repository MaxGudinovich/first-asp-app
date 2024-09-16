using System.Reflection;
using BD.Entities;
using Microsoft.EntityFrameworkCore;

namespace BD.DataAccess;

public class FilmDb : DbContext
{
    public DbSet<ActorEntity> Actors { get; set; }
    public DbSet<FilmEntity> Films { get; set; }
    public DbSet<CompanyEntity> Companies { get; set; }
    public DbSet<ActorFilmEntity> ActorFilms { get; set; }

    public FilmDb(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}