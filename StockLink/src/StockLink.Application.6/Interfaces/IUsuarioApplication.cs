using StockLink.Application._6.Commons.Bases;
using StockLink.Application._6.Dtos.Usuario.Request;
using StockLink.Application._6.Dtos.Usuario.Response;
using StockLink.Infrastructure._6.Commons.Bases.Request;
using StockLink.Infrastructure._6.Commons.Bases.Response;

namespace StockLink.Application._6.Interfaces
{
    public interface IUsuarioApplication
    {
        Task<BaseResponse<BaseEntityResponse<UsuarioResponseDto>>> ListUsuarios(BaseFiltersRequest filters);
        Task<BaseResponse<UsuarioByIdResponseDto>> UsuarioById(int id);
        Task<BaseResponse<UsuarioByIdResponseDto>> UsuarioByUser(string user);
        Task<BaseResponse<bool>> RegisterUsuario(UsuarioRequestDto requestDto);
        Task<BaseResponse<bool>> EditUsuario(int id, UsuarioRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveUsuario(int id);
    }
}
