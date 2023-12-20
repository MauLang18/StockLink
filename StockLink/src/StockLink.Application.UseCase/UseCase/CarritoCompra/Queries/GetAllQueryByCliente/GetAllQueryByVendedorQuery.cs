using MediatR;
using StockLink.Application.Dtos.CarritoCompra.Response;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.CarritoCompra.Queries.GetAllQueryByVendedor
{
    public class GetAllQueryByVendedorQuery : IRequest<BaseResponse<IEnumerable<GetAllCarritoCompraResponseDto>>>
    {
        public string? Vendedor { get; set; }
    }
}
