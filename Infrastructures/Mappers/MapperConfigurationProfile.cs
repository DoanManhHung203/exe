using Application.Commons;
using AutoMapper;

namespace Infrastructures.Mappers;

public class MapperConfigurationProfile : Profile
{
    public MapperConfigurationProfile()
    {
        CreateMap(typeof(Pagination<>), typeof(Pagination<>));
    }
}