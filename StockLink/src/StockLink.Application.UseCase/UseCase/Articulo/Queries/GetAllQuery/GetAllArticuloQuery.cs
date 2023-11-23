using MediatR;
using StockLink.Application.Dtos.Articulo.Response;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.Articulo.Queries.GetAllQuery
{
    public class GetAllArticuloQuery : IRequest<BaseResponse<IEnumerable<GetAllArticuloResponseDto>>>
    {
        public string? DESC { get; set; }
        public string? PRIV {  get; set; }
        public string? ORDER { get; set; }
    }
}
