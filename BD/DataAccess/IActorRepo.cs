using BD.Entities;

namespace BD.DataAccess;

public interface IActorRepo
{
    ActorEntity GetById(int id);
}

