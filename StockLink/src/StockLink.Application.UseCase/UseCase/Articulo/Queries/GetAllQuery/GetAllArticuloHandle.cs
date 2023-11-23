using MediatR;
using StockLink.Application.Dtos.Articulo.Response;
using StockLink.Application.Interface.Interface;
using StockLink.Application.UseCase.Commons.Bases;
using StockLink.Utilities.Constants;

namespace StockLink.Application.UseCase.UseCase.Articulo.Queries.GetAllQuery
{
    public class GetAllArticuloHandle : IRequestHandler<GetAllArticuloQuery, BaseResponse<IEnumerable<GetAllArticuloResponseDto>>>
    {
        private readonly IArticuloRepository _articuloRepository;

        public GetAllArticuloHandle(IArticuloRepository articuloRepository)
        {
            _articuloRepository = articuloRepository;
        }

        public async Task<BaseResponse<IEnumerable<GetAllArticuloResponseDto>>> Handle(GetAllArticuloQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<IEnumerable<GetAllArticuloResponseDto>>();

            try
            {
                var parametros = new
                {
                    DESC = request.DESC,
                    PRIV = request.PRIV,
                    ORDER = request.ORDER,
                };

                var exams = await _articuloRepository.GetAllArticulos(SP.paListaArticulo, parametros);

                if (exams is not null)
                {
                    response.IsSuccess = true;
                    response.Data = exams;
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
