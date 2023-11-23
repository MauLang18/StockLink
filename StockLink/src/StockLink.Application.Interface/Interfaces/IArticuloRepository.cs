using StockLink.Application.Dtos.Articulo.Response;

namespace StockLink.Application.Interface.Interface
{
    public interface IArticuloRepository
    {
        Task<IEnumerable<GetAllArticuloResponseDto>> GetAllArticulos(string storedProcedure, object parameter);
    }
}
