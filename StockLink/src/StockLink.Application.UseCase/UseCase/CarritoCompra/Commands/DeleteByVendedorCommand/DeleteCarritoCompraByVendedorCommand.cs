using MediatR;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.CarritoCompra.Commands.DeleteByVendedorCommand
{
    public class DeleteCarritoCompraByVendedorCommand : IRequest<BaseResponse<bool>>
    {
        public string? Vendedor { get; set; }
    }
}
