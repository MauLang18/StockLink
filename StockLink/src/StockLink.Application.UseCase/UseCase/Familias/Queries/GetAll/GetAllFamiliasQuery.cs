using MediatR;
using StockLink.Application.Dtos.Familia.Response;
using StockLink.Application.UseCase.Commons.Bases;

namespace StockLink.Application.UseCase.UseCase.Familias.Queries.GetAll
{
    public class GetAllFamiliasQuery : IRequest<BaseResponse<IEnumerable<GetAllFamiliaResponseDto>>>
    {
    }
}
