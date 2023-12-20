using MediatR;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.CarritoCompra.Commands.UpdateCommand
{
    public class UpdateCarritoCompraCommand : IRequest<BaseResponse<bool>>
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
    }
}
