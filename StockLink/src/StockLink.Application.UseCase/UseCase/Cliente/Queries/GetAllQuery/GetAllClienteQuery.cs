using MediatR;
using StockLink.Application.Dtos.Cliente.Response;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.Cliente.Queries.GetAllQuery
{
    public class GetAllClienteQuery : IRequest<BaseResponse<IEnumerable<GetAllClienteResponseDto>>>
    {
        public string? CLIE { get; set; }
    }
}