using MediatR;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.CarritoCompra.Commands.DeleteCommand
{
    public class DeleteCarritoCompraCommand : IRequest<BaseResponse<bool>>
    {
        public int Id { get; set; }
    }
}
