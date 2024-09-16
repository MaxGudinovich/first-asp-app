using BD.Entities.Models;

namespace BD.Services;
public interface IActorService
{
    ActorModel GetById(int id);
}

