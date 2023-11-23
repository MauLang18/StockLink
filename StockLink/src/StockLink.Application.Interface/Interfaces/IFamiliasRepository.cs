using StockLink.Application.Dtos.Familia.Response;

namespace StockLink.Application.Interface.Interface
{
    public interface IFamiliasRepository
    {
        Task<IEnumerable<GetAllFamiliaResponseDto>> GetAllFamilias(string storedProcedure, object parameter);
    }
}
