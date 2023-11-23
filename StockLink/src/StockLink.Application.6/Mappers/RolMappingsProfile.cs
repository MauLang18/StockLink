using AutoMapper;
using StockLink.Application._6.Dtos.Rol.Request;
using StockLink.Application._6.Dtos.Rol.Response;
using StockLink.Domain._6.Entities;
using StockLink.Infrastructure._6.Commons.Bases.Response;

namespace StockLink.Application._6.Mappers
{
    public class RolMappingsProfile : Profile
    {
        public RolMappingsProfile()
        {
            CreateMap<TbRol, RolResponseDto>()
                .ReverseMap();
            CreateMap<BaseEntityResponse<TbRol>, BaseEntityResponse<RolResponseDto>>()
                .ReverseMap();
            CreateMap<RolRequestDto, TbRol>()
                .ReverseMap();
            CreateMap<TbRol, RolSelectResponseDto>()
                .ReverseMap();
        }
    }
}
