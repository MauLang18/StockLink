using MediatR;
using StockLink.Application.Dtos.Cliente.Response;
using StockLink.Application.Interface.Interfaces;
using StockLink.Application.UseCase.Commons.Bases;
using StockLink.Utilities.Constants;

namespace StockLink.Application.UseCase.UseCase.Cliente.Queries.GetAllQuery
{
    public class GetAllClienteHandle : IRequestHandler<GetAllClienteQuery, BaseResponse<IEnumerable<GetAllClienteResponseDto>>>
    {
        private readonly IClienteRepository _clienteRepository;

        public GetAllClienteHandle(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<BaseResponse<IEnumerable<GetAllClienteResponseDto>>> Handle(GetAllClienteQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<IEnumerable<GetAllClienteResponseDto>>();

            try
            {
                var parametros = new
                {
                    CLIE = request.CLIE,
                };

                var clientes = await _clienteRepository.GetAllClientes(SP.paListaClientes, parametros);

                if (clientes is not null)
                {
                    response.IsSuccess = true;
                    response.Data = clientes;
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
