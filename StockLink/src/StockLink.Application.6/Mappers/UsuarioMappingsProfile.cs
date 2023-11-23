using AutoMapper;
using StockLink.Application._6.Dtos.Usuario.Request;
using StockLink.Application._6.Dtos.Usuario.Response;
using StockLink.Domain._6.Entities;
using StockLink.Infrastructure._6.Commons.Bases.Response;

namespace StockLink.Application._6.Mappers
{
    public class UsuarioMappingsProfile : Profile
    {
        public UsuarioMappingsProfile()
        {
            CreateMap<TbUsuario, UsuarioResponseDto>()
                .ForMember(x => x.Rol, x => x.MapFrom(y => y.RolNavigation.Rol))
                .ReverseMap();
            CreateMap<TbUsuario, UsuarioByIdResponseDto>()
                .ReverseMap();
            CreateMap<BaseEntityResponse<TbUsuario>, BaseEntityResponse<UsuarioResponseDto>>()
                .ReverseMap();
            CreateMap<UsuarioRequestDto, TbUsuario>()
                .ReverseMap();
            CreateMap<TokenRequestDto, TbUsuario>();
        }
    }
}
