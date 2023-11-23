using StockLink.Application._6.Commons.Bases;
using StockLink.Application._6.Dtos.Rol.Request;
using StockLink.Application._6.Dtos.Rol.Response;
using StockLink.Infrastructure._6.Commons.Bases.Request;
using StockLink.Infrastructure._6.Commons.Bases.Response;

namespace StockLink.Application._6.Interfaces
{
    public interface IRolApplication
    {
        Task<BaseResponse<BaseEntityResponse<RolResponseDto>>> ListRoles(BaseFiltersRequest filters);
        Task<BaseResponse<IEnumerable<RolSelectResponseDto>>> ListSelectRol();
        Task<BaseResponse<RolResponseDto>> RolById(int id);
        Task<BaseResponse<bool>> RegisterRol(RolRequestDto requestDto);
        Task<BaseResponse<bool>> EditRol(int id, RolRequestDto requestDto);
        Task<BaseResponse<bool>> RemoveRol(int id);
    }
}
