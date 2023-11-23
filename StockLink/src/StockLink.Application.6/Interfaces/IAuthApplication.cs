using StockLink.Application._6.Commons.Bases;
using StockLink.Application._6.Dtos.Usuario.Request;

namespace StockLink.Application._6.Interfaces
{
    public interface IAuthApplication
    {
        Task<BaseResponse<string>> Login(TokenRequestDto requestDto);
    }
}
