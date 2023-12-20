using MediatR;
using StockLink.Application.Dtos.CarritoCompra.Response;
using StockLink.Application.Interface.Interfaces;
using StockLink.Application.UseCase.Commons.Bases;
using StockLink.Utilities.Constants;

namespace StockLink.Application.UseCase.UseCase.CarritoCompra.Queries.GetAllQueryByVendedor
{
    public class GetAllQueryByVendedorHandle : IRequestHandler<GetAllQueryByVendedorQuery, BaseResponse<IEnumerable<GetAllCarritoCompraResponseDto>>>
    {
        private readonly ICarritoCompraRepository _carritoCompraRepository;

        public GetAllQueryByVendedorHandle(ICarritoCompraRepository carritoCompraRepository)
        {
            _carritoCompraRepository = carritoCompraRepository;
        }

        public async Task<BaseResponse<IEnumerable<GetAllCarritoCompraResponseDto>>> Handle(GetAllQueryByVendedorQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<IEnumerable<GetAllCarritoCompraResponseDto>>();

            try
            {
                var parametros = new
                {
                    Vendedor = request.Vendedor,
                };

                var carritoCompra = await _carritoCompraRepository.GetAllCarritoByVendedor(SP.paListaCarritoCompraByVendedor, parametros);

                if (carritoCompra is not null)
                {
                    response.IsSuccess = true;
                    response.Data = carritoCompra;
                    response.Message = GlobalMessage.MESSAGE_QUERY;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
