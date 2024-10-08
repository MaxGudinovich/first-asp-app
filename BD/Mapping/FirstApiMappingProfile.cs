using AutoMapper;
using BD.Entities;
using BD.Entities.Models;

namespace BD.Mapping;

public class FirstApiMappingProfile : Profile
{
    public FirstApiMappingProfile()
    {
        CreateMap<FilmDTO, FilmEntity>().ReverseMap();
        CreateMap<FilmModel, FilmEntity>().ReverseMap();
        CreateMap<CompanyModel, CompanyEntity>().ReverseMap();
        CreateMap<ActorModel, ActorEntity>().ReverseMap();
    }
}