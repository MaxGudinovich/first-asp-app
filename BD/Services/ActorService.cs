using AutoMapper;
using BD.DataAccess;
using BD.Entities;
using BD.Entities.Models;

namespace BD.Services;

public class ActorService : IActorService
{
    private readonly IActorRepo _repo;
    private readonly IMapper _mapper;

    public ActorService(IActorRepo repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public ActorModel GetById(int id)
    {
        var entity = _repo.GetById(id);

        var result = _mapper.Map<ActorEntity, ActorModel>(entity);

        return result;
    }
}